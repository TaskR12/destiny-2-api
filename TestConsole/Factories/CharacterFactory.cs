using Destiny2.Api.Model.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Model;

namespace TestConsole.Factories
{
    public class CharacterFactory
    {

        public Character GetCharacter(DestinyCharacterResponse component)
        {
            var charComponent = component.Character.Data;
            var character = new Character()
            {
                MembershipId = charComponent.MembershipId,
                DateLastPlayed = charComponent.DateLastPlayed,
                TotalPlaytime = TimeSpan.FromMinutes(charComponent.MinutesPlayedTotal),
                Light = charComponent.Light,
                Mobility = charComponent.Stats[2996146975],
                Resilience = charComponent.Stats[392767087],
                Recovery = charComponent.Stats[1943323491],
                Gender = charComponent.GenderType,
                Class = charComponent.ClassType,
                Race = charComponent.RaceType,
                Equipment = new List<Item>()
            };

            var itemFactory = new ItemFactory();
            var items = new List<Item>();

            foreach(var item in component.Equipment.Data.Items)
            {
                items.Add(itemFactory.GetItem(charComponent.MembershipType, charComponent.MembershipId, item.ItemHash, (long)item.ItemInstanceId));
            }

            character.Equipment = items;
            return character;
        }
    }
}
