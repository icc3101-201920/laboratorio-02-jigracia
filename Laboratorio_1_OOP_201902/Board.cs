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
        private List<int>[] totalAttackPointsMelee;
        private List<int>[] totalAttackPointsRange;
        private List<int>[] totalAttackPointsLongRange;

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
        public List<int>[] TotalAttackPointsMelee { get => totalAttackPointsMelee; set => totalAttackPointsMelee = value; }
        public List<int>[] TotalAttackPointsRange { get => totalAttackPointsRange; set => totalAttackPointsRange = value; }
        public List<int>[] TotalAttackPointsLongRange { get => totalAttackPointsLongRange; set => totalAttackPointsLongRange = value; }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
            this.totalAttackPointsMelee = new List<int>[DEFAULT_NUMBER_OF_PLAYERS];
            this.totalAttackPointsRange = new List<int>[DEFAULT_NUMBER_OF_PLAYERS];
            this.totalAttackPointsLongRange = new List<int>[DEFAULT_NUMBER_OF_PLAYERS];
        }

        

        //Metodos
        public void AddMeleeCard(int PlayerId, CombatCard combatCard)
        {
            MeleeCards[PlayerId].Add(combatCard);
        }
        public void AddRangeCard(int PlayerId, CombatCard combatCard)
        {
            RangeCards[PlayerId].Add(combatCard);
        }
        public void AddLongRangeCard(int PlayerId, CombatCard combatCard)
        {
            LongRangeCards[PlayerId].Add(combatCard);
        }
        public void AddCombatCard(int PlayerId, CombatCard combatCard)
        {
            switch (combatCard.Type)
            {
                case "Melee":
                    AddMeleeCard(PlayerId,combatCard);
                    break;
                case "Range":
                    AddRangeCard(PlayerId, combatCard);
                    break;
                case "LonRange":
                    AddLongRangeCard(PlayerId, combatCard);
                    break;

            }
        }
        public void AddSpecialCard(int PlayerId, SpecialCard specialCard,string buffType)
        {
            throw new NotImplementedException();
        }
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void DestroyMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialMeleeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialLongRangeCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyWeatherCard(int PlayerId)
        {
            throw new NotImplementedException();
        }
        public void DestroyCombatCard(int PlayerId)
        {
            MeleeCards[PlayerId].Clear();
            RangeCards[PlayerId].Clear();
            LongRangeCards[PlayerId].Clear();
        }
        public void DestroySpecialCard()
        {
            SpecialMeleeCards = 0;
        }
        public List<int>[] GetMeleeAttackPoints()
        {
            for (int i = 0; i < MeleeCards.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < MeleeCards[i].Count; j++)
                {
                    cont+=MeleeCards[i][j].AttackPoints;
                }
                TotalAttackPointsMelee[i].Add(cont);
            }
            return TotalAttackPointsMelee;
        }
        public List<int>[] GetRangeAttackPoints()
        {
            for (int i = 0; i < RangeCards.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < RangeCards[i].Count; j++)
                {
                    cont += RangeCards[i][j].AttackPoints;
                }
                TotalAttackPointsRange[i].Add(cont);
            }
            return TotalAttackPointsRange;
        }
        public List<int>[] GetLongRangeAttackPoints()
        {
            for (int i = 0; i < LongRangeCards.Length; i++)
            {
                int cont = 0;
                for (int j = 0; j < LongRangeCards[i].Count; j++)
                {
                    cont += LongRangeCards[i][j].AttackPoints;
                }
                TotalAttackPointsLongRange[i].Add(cont);
            }
            return TotalAttackPointsLongRange;
        }
    }
}
