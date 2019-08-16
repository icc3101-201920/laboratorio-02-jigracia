using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }

        

        //Metodos
        public void AddMeleeCard(object PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddRangeCard(object PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddLongRangeCard(object PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddCombatCard(object PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddSpecialCard(object PlayerId, SpecialCard specialCard,string buffType)
        {
            throw new NotImplementedException();
        }
        public void AddCaptainCard(object PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void AddWeatherCard(object PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void DestroyMeleeCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyRangeCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyLongRangeCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialMeleeCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialRangeCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialLongRangeCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyWeatherCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyCombatCard(object PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialCard()
        {
            throw new NotImplementedException();
        }
        public int[] GetMeleeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
    }
}
