﻿using Sds.Inn.DoNotChange;

namespace Sds.Inn;

public class Inventory
{
    private readonly IItemProvider _itemProvider;

    public Inventory(IItemProvider itemProvider)
    {
        _itemProvider = itemProvider;
    }

   
    public void AddNewConfiguration()
    {
        _itemProvider.AddItems();
    }

    public void UpdateQuality()
    {
        var items = _itemProvider.GetItems().ToArray();

        for (var i = 0; i < items.Count(); i++)
        {
            if (items[i].Name != "Aged Brie" && items[i].Name != "Backstage Passes")
            {
                if (items[i].Quality > 0)
                {
                    if (items[i].Name != "Sulfuras")
                    {
                        items[i].Quality = items[i].Quality - 1;
                    }
                }
            }
            else
            {
                if (items[i].Quality < 50)
                {
                    items[i].Quality = items[i].Quality + 1;
                    if (items[i].Name == "Backstage Passes")
                    {
                        if (items[i].SellIn < 11)
                        {
                            if (items[i].Quality < 50)
                            {
                                items[i].Quality = items[i].Quality + 1;
                            }
                        }
                        if (items[i].SellIn < 6)
                        {
                            if (items[i].Quality < 50)
                            {
                                items[i].Quality = items[i].Quality + 1;
                            }
                        }
                    }
                }
            }
            if (items[i].Name != "Sulfuras")
            {
                items[i].SellIn = items[i].SellIn - 1;
            }
            if (items[i].SellIn < 0)
            {
                if (items[i].Name != "Aged Brie")
                {
                    if (items[i].Name != "Backstage passes")
                    {
                        if (items[i].Quality > 0)
                        {
                            if (items[i].Name != "Sulfuras")
                            {
                                items[i].Quality = items[i].Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        items[i].Quality = items[i].Quality - items[i].Quality;
                    }
                }
                else
                {
                    if (items[i].Quality < 50)
                    {
                        items[i].Quality = items[i].Quality + 1;
                    }
                }
            }
        }
    }
}
