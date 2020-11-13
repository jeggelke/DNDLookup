using DNDLookup.DNDObjects.DNDObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DNDLookup.DNDObjects
{
    public class CharacterClass : BaseObject
    {
        [JsonProperty("hit_die")]
        public int HitDie { get; set; }
        
        [JsonProperty("proficiency_choices")]
        public List<ProficiencyChoice> ProficiencyChoices;

        [JsonProperty("proficiencies")]
        public List<Proficiency> Proficiencies;

        [JsonProperty("saving_throws")]
        public List<SavingThrows> SavingThrows;
        
        [JsonProperty("starting_equipment")]
        public StartingEquipment StartingEquipment;
        
        [JsonProperty("class_levels")]
        public ClassLevels ClassLevels;
        
        [JsonProperty("subclasses")]
        public List<Subclasses> Subclasses;

        [JsonProperty("spellcasting")]
        public Spellcasting Spellcasting;
    }
}
