using FourFlagsRPG.Models.Contracts.Enemies;
using FourFlagsRPG.Models.Contracts.Items;
using FourFlagsRPG.Models.Contracts.Quests;
using FourFlagsRPG.Models.Enums;
using FourFlagsRPG.Models.Models.Quests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FourFlags.BusinessLogic.Controllers.Quest
{
    public class QuestController
    {
        private const string pattern = @"#Type(?:.*)[\r\n]+([\w\W\r\n]+)#Name(?:.*)[\r\n]+([\w\W\r\n]+)#Description(?:.*)[\r\n]+([\w\W\r\n]+)#Progress(?:.*)[\r\n]+([\w\W\r\n]+)#ItemRewards(?:.*)[\r\n]+([\w\W\r\n]+)#ExperienceReward(?:.*)[\r\n]+([\w\W\r\n]+)";

        private List<IQuest> quests;
        private List<IEnemy> enemies;
        private List<IItem> items;

        public QuestController(List<IItem> items, List<IEnemy> enemies)
        {
            this.quests = new List<IQuest>();
            this.enemies = enemies;
            this.items = items;

            this.InitializeQuests();
        }

        public IReadOnlyList<IQuest> Quests
        {
            get { return this.quests.AsReadOnly(); }
        }

        public void InitializeQuests()
        {
            // Get Quest Directory
            string directory = this.GetQuestDirectory();

            // Read Quest Files from Directory;
            this.ReadQuests(directory);
        }

        private void ReadQuests(string directory)
        {
            Regex regex = new Regex(pattern);
            string[] allQuests = this.GetQuestNames(directory);
            string questArgs = String.Empty;

            for (int i = 0; i < allQuests.Length; i++)
            {
                using (StreamReader reader = new StreamReader(allQuests[i]))
                {
                    questArgs = reader.ReadToEnd();
                }

                Match match = regex.Match(questArgs);

                Quests questType = (Quests)Enum.Parse(typeof(Quests), match.Groups[1].ToString().Trim());
                string name = match.Groups[2].ToString().Trim();
                string description = match.Groups[3].ToString().Trim();
                string[] progress = this.SplitByNewLineAndTrim(match.Groups[4].ToString());
                string[] itemRewards = this.SplitByNewLineAndTrim(match.Groups[5].ToString());
                int experienceReward = int.Parse(match.Groups[6].ToString().Trim());

                IQuest currentQuest = null;

                if (questType == FourFlagsRPG.Models.Enums.Quests.GatherQuest)
                {
                    currentQuest = new GatherQuest(i + 1, name, description, experienceReward, this.GetItems(progress), this.GetItems(itemRewards));
                }
                else if (questType == FourFlagsRPG.Models.Enums.Quests.HuntQuest)
                {
                    currentQuest = new HuntQuest(i + 1, name, description, experienceReward, this.GetEnemies(progress), this.GetItems(itemRewards));
                }

                this.quests.Add(currentQuest);
            }
        }

        private string GetQuestDirectory()
        {
            // Get Main Directory
            Type type = Type.GetType(this.ToString());
            string projectName = type.Namespace.Split('.').First();
            string currentDirectory = Directory.GetCurrentDirectory();
            int indexOfFolderInString = currentDirectory.LastIndexOf(projectName, StringComparison.Ordinal);
            string directory = currentDirectory.Substring(0, indexOfFolderInString);

            // Go to Quests Folder(Create if non-existant)
            string[] allDirectories = Directory.GetDirectories(directory);
            bool createHelpFile = false;

            if (allDirectories.All(d => d != "Quests"))
            {
                Directory.CreateDirectory($"{directory}Quests");
                createHelpFile = true;
            }
            directory = $"{directory}Quests\\";

            if (createHelpFile)
            {
                CreateHelpFIle(directory);
            }

            return directory;
        }

        private string[] GetQuestNames(string directory)
        {
            return Directory.GetFiles(directory).Where(f => f.EndsWith(".quest")).ToArray();
        }

        private string[] SplitByNewLineAndTrim(string str)
        {
            return str.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        private List<IItem> GetItems(string[] itemsArgs)
        {
            List<IItem> itemRewards = new List<IItem>();

            foreach (string itemInfo in itemsArgs)
            {
                int itemId = int.Parse(itemInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last());

                IItem item = this.items.FirstOrDefault(i => i.ID == itemId);

                if (item != null)
                {
                    itemRewards.Add(item);
                }
            }

            return itemRewards;
        }

        private List<IEnemy> GetEnemies(string[] allEnemyArgs)
        {
            List<IEnemy> enemies = new List<IEnemy>();

            foreach (string enemyInfo in allEnemyArgs)
            {
                int enemyId = int.Parse(enemyInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last());

                //IEnemy enemy = this.enemies.FirstOrDefault(i => i.ID == enemyId);

                //if (enemy != null)
                //{
                //    enemies.Add(enemy);
                //}
            }

            return enemies;
        }

        private void CreateHelpFIle(string directory)
        {
            StringBuilder helpText = new StringBuilder();

            helpText.AppendLine("Quest file must end with .quest and have:");
            helpText.AppendLine("#Type - GatherQuest or HuntQuest");
            helpText.AppendLine("#Name");
            helpText.AppendLine("#Description");
            helpText.AppendLine("#Progress");
            helpText.AppendLine("#ItemRewards (item - id)");
            helpText.AppendLine("#ExperienceReward");

            using (StreamWriter writer = new StreamWriter($"{directory}help.txt"))
            {
                writer.Write(helpText);
            }
        }
    }
}