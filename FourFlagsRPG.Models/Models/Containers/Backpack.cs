namespace FourFlagsRPG.Models.Models.Containers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FourFlagsRPG.Models.Contracts.Items;


   public class Backpack : IContainer
   {
       private const int BackPackSlots = 15;

       private readonly List<ISlot> slotList;

      
       public Backpack()
       {
           this.slotList = new List<ISlot>();
           for (int i = 0; i < BackPackSlots; i++)
           {
               this.slotList.Add(new Slot());
           }
       }

       public IEnumerable<ISlot> SlotList
       {
           get { return this.slotList; }
       }

       public void LootItem(IGameItem itemToBeLooted)
       {
           ISlot emptySlot = this.SlotList.FirstOrDefault(x => x.IsEmpty);

           if (emptySlot == null)
           {
               throw new ArgumentException("Your backpack is full.");
           }

           emptySlot.GameItem = itemToBeLooted;
           emptySlot.IsEmpty = false;
       }

       public void RemoveItem(ISlot slot)
       {
           slot.GameItem = null;
           slot.IsEmpty = true;
       }

       public void RemoveLastItem()
       {
           this.RemoveLastItemInternal();
       }

       public void ListItems()
       {
            // Console OR WPF
           var fullSlots = this.SlotList.Where(x => !x.IsEmpty);
           foreach (ISlot currentSlot in fullSlots)
           {
               Console.WriteLine(currentSlot.GameItem.ToString());
           }

           Console.WriteLine("Empty slots: {0}",
               this.SlotList.Count() - fullSlots.Count());
          
       }

       private void RemoveLastItemInternal()
       {
           /* Method which removes the last collected item from the backpack
           (sets new object at that index) if the player wants to collect another one */
           int indexOfElemenToRemove = slotList.IndexOf(
                                           slotList.FirstOrDefault(slot => slot.IsEmpty)) - 1;

           if (indexOfElemenToRemove == -1)
           {
               throw new ArgumentException("Invalid operation. Your backpack is empty.");
           }

           if (indexOfElemenToRemove == -2)
           {
               indexOfElemenToRemove = this.slotList.Count - 1; /*last element, because indexOf returns -1, 
                when it doesn't find element (empty slot) - 1 = -2 */
           }

           this.slotList.RemoveAt(indexOfElemenToRemove);
           this.slotList.Insert(indexOfElemenToRemove, new Slot());
       }
    }
}
