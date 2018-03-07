using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterSheet.Other;

namespace CharacterSheet.Container
{
    public class Feats
    {
        public Feats() { }
        public List<Feat> AllFeats()
        {
            List<Feat> listfeats = new List<Feat>();
            #region A
            listfeats.Add(Acrobatic());
            listfeats.Add(Agile());
            listfeats.Add(Alertness());
            listfeats.Add(AnimalAffinity());
            listfeats.Add(ArmorProficiencyHeavy());
            listfeats.Add(ArmorProficiencyLight());
            listfeats.Add(ArmorProficiencyMedium());
            listfeats.Add(Athletic());
            listfeats.Add(AugmentSummoning());
            #endregion
            #region B
            listfeats.Add(BlindFight());
            listfeats.Add(BrewPotion());
            #endregion
            #region C
            listfeats.Add(Cleave());
            listfeats.Add(CombatCasting());
            listfeats.Add(CombatExpertise());
            listfeats.Add(CombatReflexes());
            listfeats.Add(CraftMagicArmsAndArmor());
            listfeats.Add(CraftRod());
            listfeats.Add(CraftStaff());
            listfeats.Add(CraftWand());
            listfeats.Add(CraftWondrousItem());
            #endregion
            #region D
            listfeats.Add(Deceitful());
            listfeats.Add(DeflectArrows());
            listfeats.Add(DeftHands());
            listfeats.Add(Diehard());
            listfeats.Add(Diligent());
            listfeats.Add(Dodge());
            #endregion
            #region E
            listfeats.Add(EmpowerSpell());
            listfeats.Add(Endurance());
            listfeats.Add(EnlargeSpell());
            listfeats.Add(EschewMaterials());
            listfeats.Add(ExoticWeaponProficiency("Choose Weapon"));
            listfeats.Add(ExtendSpell());
            listfeats.Add(ExtraTurning());
            #endregion
            #region F
            listfeats.Add(FarShot());
            listfeats.Add(ForgeRing());
            #endregion
            #region G
            listfeats.Add(GreatCleave());
            listfeats.Add(GreatFortitude());
            listfeats.Add(GreaterSpellFocus("Choose School"));
            listfeats.Add(GreaterSpellPenetration());
            listfeats.Add(GreaterTwoWeaponFighting());
            listfeats.Add(GreaterWeaponFocus("Choose Weapon"));
            listfeats.Add(GreaterWeaponSpecialization("Choose Weapon"));
            #endregion
            #region H
            listfeats.Add(HeightenSpell());
            #endregion
            #region I
            listfeats.Add(ImprovedBullRush());
            listfeats.Add(ImprovedCounterspell());
            listfeats.Add(ImprovedCritical("Choose Weapon"));
            listfeats.Add(ImprovedFeint());
            listfeats.Add(ImprovedGrapple());
            listfeats.Add(ImprovedInitiative());
            listfeats.Add(ImprovedOverrun());
            listfeats.Add(ImprovedPreciseShot());
            listfeats.Add(ImprovedShieldBash());
            listfeats.Add(ImprovedSunder());
            listfeats.Add(ImprovedTrip());
            listfeats.Add(ImprovedTurning());
            listfeats.Add(ImprovedTwoWeaponFighting());
            listfeats.Add(ImprovedUnarmedStrike());
            listfeats.Add(Investigator());
            listfeats.Add(IronWill());
            #endregion
            #region L
            listfeats.Add(Leadership());
            listfeats.Add(LightningReflexes());
            #endregion
            #region M
            listfeats.Add(MagicalAptitude());
            listfeats.Add(Manyshot());
            listfeats.Add(MartialWeaponProficiency("Choose Weapon"));
            listfeats.Add(MaximizeSpell());
            listfeats.Add(Mobility());
            listfeats.Add(MountedArchery());
            listfeats.Add(MountedCombat());
            #endregion
            #region N
            listfeats.Add(NaturalSpell());
            listfeats.Add(Negotiator());
            listfeats.Add(NimbleFingers());
            #endregion
            #region P
            listfeats.Add(Persuasive());
            listfeats.Add(PointBlankShot());
            listfeats.Add(PowerAttack());
            listfeats.Add(PreciseShot());
            #endregion
            #region Q
            listfeats.Add(QuickDraw());
            listfeats.Add(QuickenSpell());
            #endregion
            #region R
            listfeats.Add(RapidReload("Choose Weapon"));
            listfeats.Add(RapidShot());
            listfeats.Add(RideByAttack());
            listfeats.Add(Run());
            #endregion
            #region S
            listfeats.Add(ScribeScroll());
            listfeats.Add(SelfSufficient());
            listfeats.Add(ShieldProficiency());
            listfeats.Add(ShootOnTheRun());
            listfeats.Add(SilentSpell());
            listfeats.Add(SimpleWeaponProficiency());
            listfeats.Add(SimpleWeaponProficiency("Choose Weapon"));
            listfeats.Add(SkillFocus("Choose Skill"));
            listfeats.Add(SnatchArrows());
            listfeats.Add(SpellFocus("Choose Spell"));
            listfeats.Add(SpellMastery());
            listfeats.Add(SpellPenetration());
            listfeats.Add(SpiritedCharge());
            listfeats.Add(SpringAttack());
            listfeats.Add(Stealthy());
            listfeats.Add(StillSpell());
            listfeats.Add(StunningFist());
            #endregion
            #region T
            listfeats.Add(Toughness());
            listfeats.Add(TowerShieldProficiency());
            listfeats.Add(Track());
            listfeats.Add(Trample());
            listfeats.Add(TwoWeaponDefense());
            listfeats.Add(TwoWeaponFighting());
            #endregion
            #region W
            listfeats.Add(WeaponFinesse());
            listfeats.Add(WeaponFocus("Choose Weapon"));
            listfeats.Add(WeaponSpecialization("Choose Weapon"));
            listfeats.Add(WhirlwindAttack());
            listfeats.Add(WidenSpell());
            #endregion
            return listfeats;
        }

        public List<Feat> FighterFeats()
        {
            return ClassRelatedFeats("Fighter");
        }
        public List<Feat> MonkFeats()
        {
            return ClassRelatedFeats("Monk");
        }
        public List<Feat> WizardFeat()
        {
            return ClassRelatedFeats("Wizard");
        }

        private List<Feat> ClassRelatedFeats(string _class)
        {
            List<Feat> listfeats = new List<Feat>();
            foreach (Feat item in AllFeats())
            {
                if (item.ClassBonus.Count > 0)
                {
                    foreach (string fighter in item.ClassBonus)
                    {
                        if (fighter.Equals(_class))
                        {
                            listfeats.Add(item);
                        }
                    }
                }
            }

            return listfeats;
        }


        class FeatComparer : IEqualityComparer<Feat>
        {
            public bool Equals(Feat x, Feat y)
            {
                return x.Equals(y);
            }
            public int GetHashCode(Feat obj)
            {
                return obj.GetHashCode();
            }
        }

        public bool RequirementSet(Feat _toPass, string[] _reqString, List<Feat> _reqFeats, List<KeyValuePair<string, int>> _reqKeyPair)
        {

            bool res = true;
            if (_toPass.Prerequisite.Count() > 0)
            {
                foreach (object obj in _toPass.Prerequisite)
                {
                    if (obj is string)
                        foreach (string reqString in _reqString)
                            if (!obj.Equals(reqString))
                                res = false;
                            else if (obj is Feat)
                                foreach (Feat reqFeat in _reqFeats)
                                {
                                    string tempName = FeatName((Feat)obj);
                                    if (!tempName.Equals(reqFeat.Name))
                                        res = false;
                                }

                            else if (obj is KeyValuePair<string, int>)
                                foreach (KeyValuePair<string, int> reqKeyPair in _reqKeyPair)
                                    if (!MinimumReq(reqKeyPair, (KeyValuePair<string, int>)obj))
                                        res = false;
                                    else
                                        res = false;
                }
            }

            return res;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="_stat">1 Strength, 2 Dexterity, 3 Constituion, 4 Intelligence, 5 Wisdom, 6 Charisma, 7 Appearance</param>
        /// <param name="_amount">The amount</param>
        /// <returns></returns>
        private KeyValuePair<string, int> RequiredStat(int _stat, int _amount)
        {
            string chosen = "";
            switch (_stat)
            {
                case 1: chosen = "Strength"; break;
                case 2: chosen = "Dexterity"; break;
                case 3: chosen = "Constitution"; break;
                case 4: chosen = "Intelligence"; break;
                case 5: chosen = "Wisdom"; break;
                case 6: chosen = "Charisma"; break;
                case 7: chosen = "Appearance"; break;
                default: break;
            }
            KeyValuePair<string, int> res = new KeyValuePair<string, int>(chosen, _amount);
            return res;

        }
        private KeyValuePair<string, int> RequiredBAB(int _amount)
        {
            string bab = "Base Attack Bonus +";
            KeyValuePair<string, int> res = new KeyValuePair<string, int>(bab, _amount);
            return res;
        }
        private KeyValuePair<string, int> RequiredSkill(string _skill, int _amount)
        {
            KeyValuePair<string, int> res = new KeyValuePair<string, int>(_skill, _amount);
            return res;
        }

        private string FeatName(Feat _feat)
        {
            return _feat.Name;
        }
        private bool MinimumReq(KeyValuePair<string, int> _keypairReq, KeyValuePair<string, int> _keypairVal)
        {
            bool res = false;
            if (_keypairReq.Key.Equals(_keypairVal.Key))
                if (_keypairReq.Value <= _keypairVal.Value)
                    res = true;
            return res;
        }

        #region A
        public Feat Acrobatic()
        {
            Feat feat = new Feat();
            feat.Name = "Acrobatic";
            feat.FType = "General";
            feat.Content = "You have excellent body awareness and coordination.";
            feat.Benefit = "You get a +2 on all Jump checks and Tumble checks.";
            return feat;
        }
        public Feat Agile()
        {
            Feat feat = new Feat();
            feat.Name = "Agile";
            feat.FType = "General";
            feat.Content = "You are particularly flexible and poised.";
            feat.Benefit = "You get a +2 bonus on all Balance checks and Escape Artist Checks.";
            return feat;
        }
        public Feat Alertness()
        {
            Feat feat = new Feat();
            feat.Name = "Alertness";
            feat.FType = "General";
            feat.Content = "You have finely tuned senses.";
            feat.Benefit = "You get a +2 bonus on all Listen checks and Spot checks.";
            feat.Special = "The master of a familiar gains the benefit of the Alertness feat whenever the familiar is within arms reach.";
            return feat;
        }
        public Feat AnimalAffinity()
        {
            Feat feat = new Feat();
            feat.Name = "AnimalAffinity";
            feat.FType = "General";
            feat.Content = "You are good with animals.";
            feat.Benefit = "You get a +2 bonus on all Handle Animals checks and Ride checks.";
            return feat;
        }
        public Feat ArmorProficiencyHeavy()
        {
            Feat feat = new Feat();
            feat.Name = "Armor Proficiency(Heavy)";
            feat.FType = "General";
            feat.Prerequisite.Add(ArmorProficiencyLight());
            feat.Prerequisite.Add(ArmorProficiencyMedium());
            feat.Content = "You are proficient with heavy armor.";
            feat.Benefit = "When you wear a type of armor with which you are proficient, the armor check penalty for that armor applies only to Balance, Climb, Escape Artist, Hide, Jump, Move Silently, Pick Pocket and Tumble checks.";
            feat.NormalWithout = "A character who is wearing armor with which he/she is not proficient applies armor check penalty to attack rolls and to all skill checks that involve moving, including Ride.";
            feat.Special = "Fighters, paladins and clerics automatically have Armor Proficiency(Heavy) as a bonus feat. They need not select it.";
            return feat;
        }
        public Feat ArmorProficiencyLight()
        {
            Feat feat = new Feat();
            feat.Name = "Armor Proficiency(Light)";
            feat.FType = "General";
            feat.Content = "You are proficient with light armor.";
            feat.Benefit = "When you wear a type of armor with which you are proficient, the armor check penalty for that armor applies only to Balance, Climb, Escape Artist, Hide, Jump, Move Silently, Pick Pocket and Tumble checks.";
            feat.NormalWithout = "A character who is wearing armor with which he/she is not proficient applies armor check penalty to attack rolls and to all skill checks that involve moving, including Ride.";
            feat.Special = "All characters except wizards, sorcerers and monks automatically have Armor Proficiency(Light) as a bonus feat. They need not select it.";
            return feat;
        }
        public Feat ArmorProficiencyMedium()
        {
            Feat feat = new Feat();
            feat.Name = "Armor Proficiency(Medium)";
            feat.FType = "General";
            feat.Prerequisite.Add(ArmorProficiencyLight());
            feat.Content = "You are proficient with medium armor.";
            feat.Benefit = "When you wear a type of armor with which you are proficient, the armor check penalty for that armor applies only to Balance, Climb, Escape Artist, Hide, Jump, Move Silently, Pick Pocket and Tumble checks.";
            feat.NormalWithout = "A character who is wearing armor with which he/she is not proficient applies armor check penalty to attack rolls and to all skill checks that involve moving, including Ride.";
            feat.Special = "Fighters, barbarians, paladins, clerics, druids and bards automatically have Armor Proficiency(Medium) as a bonus feat. They need not select it.";
            return feat;
        }
        public Feat Athletic()
        {
            Feat feat = new Feat();
            feat.Name = "Atheletic";
            feat.FType = "General";
            feat.Content = "You have a knack for athletic endeavors.";
            feat.Benefit = "You get a +2 bonus on all Climb checks and Swim checks.";
            return feat;
        }
        public Feat AugmentSummoning()
        {
            Feat feat = new Feat();
            feat.Name = "Augment Summoning";
            feat.FType = "General";
            feat.Content = "Your summoned creatures are more powerful than normal.";
            feat.Prerequisite.Add(SpellFocus("Conjuration"));
            feat.Benefit = "Each creature you conjure with any summon spell gains a +4 enhancement bonus to Strength and Constitution for the duration of the spell that summoned it.";
            return feat;
        }
        #endregion
        #region B
        public Feat BlindFight()
        {
            Feat feat = new Feat();
            feat.Name = "Blind-Fight";
            feat.FType = "General";
            feat.Content = "You know how to fight in melee without being able to see your foes.";
            feat.Benefit = "In melee, every time you miss because of concealment, you can reroll your miss chance percentile roll one time to see if you actually hit. \r\nAn invisible attacker gets no advantages related to hitting you in melee. That is you don't lose your Dexterity bonus to Armor Class, and the attacker doesn't get the usual +2 bonus for being invisible. The invisible attacker's bonus do still apply for ranged attacks, however. \r\nYou take only half the usual penalty to speed for being unable to see. Darkness and poor visibility in general reduce your speed to three-quarters normal, instead of one-half.";
            feat.NormalWithout = "Regular attack roll modifiers for invisible attacks trying to hit you apply, and you lose your Dexterity bonus to AC. The speed reduction for darkness and poor visibility also applies.";
            feat.Special = "The blind feat is of no use against a character who is the subject of a blink spell.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feat.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat BrewPotion()
        {
            Feat feat = new Feat();
            feat.Name = "Brew Potion";
            feat.FType = "Item Creation";
            feat.Content = "You can create potions which carry spells within themselves";
            feat.Prerequisite.Add("Caster level 3rd");
            feat.Benefit = "You can create a potion of any 3rd-level or lower spell that you know and that targets one or more creatures. Brewing a potion takes one day. When you create a potion, you set the caster level, which must be sufficient to cast the spell in question and no higher than your own level. The base price of a potion is its spell level × its caster level × 50 gp. To brew a potion, you must spend 1/25 of this base price in XP and use up raw materials costing one half this base price.\r\nWhen you create a potion, you make any choices that you would normally make when casting the spell. Whoever drinks the potion is the target of the spell.\r\nAny potion that stores a spell with a costly material component or an XP cost also carries a commensurate cost. In addition to the costs derived from the base price, you must expend the material component or pay the XP when creating the potion.";
            return feat;
        }
        #endregion
        #region C
        public Feat Cleave()
        {
            Feat feat = new Feat();
            feat.Name = "Cleave";
            feat.FType = "General";
            feat.Content = "You can follow through with powerful blows.";
            feat.Prerequisite.Add(RequiredStat(1, 13));
            feat.Prerequisite.Add(PowerAttack());
            feat.Benefit = "If you deal a creature enough damage to make it drop (typically by dropping it to below 0 hit points or killing it), you get an immediate, extra melee attack against another creature within reach. You cannot take a 5-foot step before making this extra attack. The extra attack is with the same weapon and at the same bonus as the attack that dropped the previous creature. You can use this ability once per round.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feat.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat CombatCasting()
        {
            Feat feat = new Feat();
            feat.Name = "Combat Casting";
            feat.FType = "General";
            feat.Content = "You are adept at casting spells in combat.";
            feat.Benefit = "You get a +4 bonus on Concentration checks made to cast a spell or use a spell-like ability while on the defensive or while you are grappling or pinned.";
            return feat;
        }
        public Feat CombatExpertise()
        {
            Feat feat = new Feat();
            feat.Name = "Combat Expertise";
            feat.FType = "General";
            feat.Content = "You are trained at using your combat skill for defense as well as offense.";
            feat.Prerequisite.Add(RequiredStat(4, 13));
            feat.Benefit = "When you use the attack action or the full attack action in melee, you can take a penalty of as much as -5 on your attack roll and add the same number (+5 or less) as a dodge bonus to your Armor Class. This number may not exceed your base attack bonus. The changes to attack rolls and Armor Class last until your next action.";
            feat.NormalWithout = "A character without the " + feat.Name + " feat can fight defensively while using the attack or full attack action to take a -4 penalty on attack rolls and gain a +2 dodge bonus to Armor Class";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feat.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat CombatReflexes()
        {
            Feat feat = new Feat();
            feat.Name = "Combat Reflexes";
            feat.FType = "General";
            feat.Content = "You can respond quickly and repeatedly to oppenents who let their defenses down.";
            feat.Benefit = "When foes leave themselves open, you may make a number of additional attacks of opportunity equal to your Dexterity bonus. For example, a fighter with a Dexterity of 15 can make a total of three attacks of opportunity in 1 round—the one attack of opportunity any character is entitled to, plus two more because of his +2 Dexterity bonus. If four goblins move out of the character’s threatened squares, he can make one attack of opportunity each against three of the four. You can still make only one attack of opportunity per opportunity.\r\nWith this feat, you may also make attacks of opportunity while flat-footed.";
            feat.NormalWithout = "A character without this feat can make only one attack of opportunity per round and can't make attacks of opportinuty while flat-footed.";
            feat.Special = "The " + feat.Name + " feat does not allow a rogue to use her opportunist ability more than once per round.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feat.\r\nA monk may select " + feat.Name + " as bonus feat at 2nd level.";
            feat.ClassBonus.Add("Fighter");
            feat.ClassBonus.Add("Monk");
            return feat;
        }
        public Feat CraftMagicArmsAndArmor()
        {
            Feat feat = new Feat();
            feat.Name = "Craft Magic Arms and Armor";
            feat.FType = "Item Creation";
            feat.Content = "You can create magic weapons, armor and shields.";
            feat.Prerequisite.Add("Caster level 5th.");
            feat.Benefit = "You can create any magic weapon, armor, or shield whose prerequisites you meet. Enhancing aweapon, suit of armor, or shield takes one day for each 1,000 gp in the price of its magical features. To enhance a weapon, suit of armor, or shield, you must spend 1/25 of its features’ total price in XP and use up raw materials costing one-half of this total price.\r\nThe weapon, armor, or shield to be enhanced must be a masterwork item that you provide. Its cost is not included in the above cost.\r\nYou can also mend a broken magic weapon, suit of armor, or shield if it is one that you could make. Doing so costs half the XP, half the raw materials, and half the time it would take to craft that item in the first place.";
            return feat;
        }
        public Feat CraftRod()
        {
            Feat feat = new Feat();
            feat.Name = "Craft Rod";
            feat.FType = "Item Creation";
            feat.Content = "You can create magic rods, which have varied magical effects.";
            feat.Prerequisite.Add("Caster level 9th.");
            feat.Benefit = "You can create any rod whose prerequisites you meet. Crafting a rod takes one day for each 1,000 gp in its base price. To craft a rod, you must spend 1/25 of its base price in XP and use up raw materials costing one-half of its base price.\r\nSome rods incur extra costs in material components or XP, as noted in their descriptions. These costs are in addition to those derived from the rod’s base price.";
            return feat;
        }
        public Feat CraftStaff()
        {
            Feat feat = new Feat();
            feat.Name = "Craft Staff";
            feat.FType = "Item Creation";
            feat.Content = "You can create staffs, each of which has multiple magical effects.";
            feat.Prerequisite.Add("Caster level 12th.");
            feat.Benefit = "You can create any staff whose prerequisites you meet. Crafting a staff takes one day for each 1,000 gp in its base price. To craft a staff, you must spend 1/25 of its base price in XP and use up raw materials costing one-half of its base price. A newly created staff has 50 charges.\r\nSome staffs incur extra costs in material components or XP, as noted in their descriptions. These costs are in addition to those derived from the staff’s base price.";
            return feat;
        }
        public Feat CraftWand()
        {
            Feat feat = new Feat();
            feat.Name = "Craft Wand";
            feat.FType = "Item Creation";
            feat.Content = "You can create wands which hold spells.";
            feat.Prerequisite.Add("Caster level 5th.");
            feat.Benefit = "You can create a wand of any 4th-level or lower spell that you know. Crafting a wand takes one day for each 1,000 gp in its base price. The base price of a wand is its caster level × the spell level × 750 gp. To craft a wand, you must spend 1/25 of this base price in XP and use up raw materials costing one-half of this base price. A newly created wand has 50 charges.\r\nAny wand that stores a spell with a costly material component or an XP cost also carries a commensurate cost. In addition to the cost derived from the base price, you must expend fifty copies of the material component or pay fifty times the XP cost.";
            return feat;
        }
        public Feat CraftWondrousItem()
        {
            Feat feat = new Feat();
            feat.Name = "Craft Wondrous Item";
            feat.FType = "Item Creation";
            feat.Content = "You can create a wide variety of magic items, such as a crystal ball or a flying carpet.";
            feat.Prerequisite.Add("Caster level 3rd.");
            feat.Benefit = "You can create any wondrous item whose prerequisites you meet. Enchanting a wondrous item takes one day for each 1,000 gp in its price. To enchant a wondrous item, you must spend 1/25 of the item’s price in XP and use up raw materials costing half of this price.\r\nYou can also mend a broken wondrous item if it is one that you could make. Doing so costs half the XP, half the raw materials, and half the time it would take to craft that item in the first place.\r\nSome wondrous items incur extra costs in material components or XP, as noted in their descriptions. These costs are in addition to those derived from the item’s base price. You must pay such a cost to create an item or to mend a broken one.";
            return feat;
        }
        #endregion
        #region D
        public Feat Deceitful()
        {
            Feat feat = new Feat();
            feat.Name = "Deceitful";
            feat.FType = "General";
            feat.Content = "You have a knack for disguising the truth.";
            feat.Benefit = "You get a +2 bonus on all Disguise checks and Forgery checks.";
            return feat;
        }
        public Feat DeflectArrows()
        {
            Feat feat = new Feat();
            feat.Name = "Deflect Arrows";
            feat.FType = "General";
            feat.Content = "You can defelct incoming arrows as well as crossbow bolts, spears and other projectile or thrown weapons.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(ImprovedUnarmedStrike());
            feat.Benefit = "You must have at least one hand free (holding nothing) to use this feat. Once per round when you would normally be hit with a ranged weapon, you may deflect it so that you take no damage from it. You must be aware of the attack and not flat-footed. Attempting to deflect a ranged weapon doesn’t count as an action. Unusually massive ranged weapons, such as boulders hurled by giants, and ranged attacks generated by spell effects, such as Melf’s acid arrow, can’t be deflected.";
            feat.Special = "A monk may select " + feat.Name + " as bonus feat at 2nd level, even if he/she does not meet the prerequisites.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feat.";
            feat.ClassBonus.Add("Monk");
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat DeftHands()
        {
            Feat feat = new Feat();
            feat.Name = "Deft Hands";
            feat.FType = "General";
            feat.Content = "You have exceptional manual dexterity.";
            feat.Benefit = "You get a +2 bonus on all Sleight of Hand checks and Use Rope checks.";
            return feat;
        }
        public Feat Diehard()
        {
            Feat feat = new Feat();
            feat.Name = "Diehard";
            feat.FType = "General";
            feat.Content = "You can remain conscious after attacks that would fell others.";
            feat.Prerequisite.Add(Endurance());
            feat.Benefit = "When reduced to between –1 and –9 hit points, you automatically become stable. You don’t have to roll d% to see if you lose 1 hit point each round.\r\nWhen reduced to negative hit points, you may choose to act as if you were disabled, rather than dying. You must make this decision as soon as you are reduced to negative hit points (even if it isn’t your turn). If you do not choose to act as if you were disabled, you immediately fall unconscious.\r\nWhen using this feat, you can take either a single move or standard action each turn, but not both, and you cannot take a full-round action. You can take a move action without further injuring yourself, but if you perform any standard action (or any other action the DM deems as strenuous, including some free actions, such as casting a quickened spell) you take 1 point of damage after completing the act. If you reach –10 hit points, you immediately die.";
            feat.NormalWithout = "A character without this feat who is reduced to between -1 and -9 hit points is unconscious and dying.";
            return feat;
        }
        public Feat Diligent()
        {
            Feat feat = new Feat();
            feat.Name = "Diligent";
            feat.FType = "General";
            feat.Content = "Your meticulousness allows you to analyze minute details that others miss.";
            feat.Benefit = "You get a +2 bonus on all Appraise checks and Decipher Script checks.";
            return feat;
        }
        public Feat Dodge()
        {
            Feat feat = new Feat();
            feat.Name = "Dodge";
            feat.FType = "General";
            feat.Content = "You are adept at dodging blows.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Benefit = "During your action, you designate an opponent and recieve a +1 dodge bonus to Armor Class against attacks from that opponent. You can select a new opponent on any action.\r\nA condition that makes you lose your Dexterity bonus to Armor Class (if any) also makes you lose dodge bonuses. Also dodge bonuses (such as this one and a dwarf's racial bonus on dodge attempts against giants) stack with each other, unlike most other types of bonuses.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feat.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        #endregion
        #region E
        public Feat EmpowerSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Empower Spell";
            feat.FType = "Metamagic";
            feat.Content = "You can cast spells to greater effect.";
            feat.Benefit = "All variable, numeric effects of an empowered spell are increased by one-half. An empowered spell deals half again as much damage as normal, cures half again as many hit points, affects half again as many targets, and so forth, as appropriate. For example, an empowered magic missile deals 1-1/2 times its normal damage (roll 1d4+1 and multiply the result by 1-1/2 for each missile). Saving throws and opposed rolls (such as the one you make when you cast dispel magic) are not affected, nor are spells without random variables. An empowered spell uses up a spell slot two levels higher than the spell’s actual level.";
            return feat;
        }
        public Feat Endurance()
        {
            Feat feat = new Feat();
            feat.Name = "Endurance";
            feat.FType = "General";
            feat.Content = "You are capable of amazing feats of stamina.";
            feat.Benefit = "You gain +4 bonus on the following checks and saves: Swim checks made to resist nonlethal damage, Constitution checks made to continue running, Constitution checks made to avoid nonlethal damage from a forced march, Constitution checks made to hold your breath, Constitution checks made to avoid nonlethal damage from stavation or thirst, Fortitude saves made to avoid nonlethal damage from hot or cold environments and Fortitude saves made to resist damage from suffocation. Also you may sleep in light or medium armor without becoming fatigued.";
            feat.NormalWithout = "A character without this feat who sleeps in medium or heavier is automatically fatigued the next day.";
            feat.Special = "A ranger autimatically gains Endurance as a bonus feat at 3rd level. He need not select it.";
            return feat;
        }
        public Feat EnlargeSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Enlarge Spell";
            feat.FType = "Metamagic";
            feat.Content = "You can cast spells farther than normal.";
            feat.Benefit = "You can alter a spell with a range of close, medium or long to increase its range by 100%. An enlarged spell with a range of close now has a range of 50 ft. + 5 ft/level, while medium-range spells have a range of 200 ft. + 20 ft./level and long long-range spells have a range of 800 ft. + 80 ft./level. An enlarged spell uses up a spell slot one level higher than the spells actual level.\r\nSpells whose ranges are not defined by distances, as well as spells whose ranges are not close, medium or long, do not have increased ranges.";
            return feat;
        }
        public Feat EschewMaterials()
        {
            Feat feat = new Feat();
            feat.Name = "Eschew Materials";
            feat.FType = "General";
            feat.Content = "You can cast spells without relying on material components.";
            feat.Benefit = "You can cast any spell that has a material component costing 1 gp or less without needing that component. (The casting of the spell still provokes attacks of opportunity as normal.) If the spell requires a material component that costs more than 1 gp you must have the material component at hand to cast the spell, just as normal.";
            return feat;
        }
        public Feat ExoticWeaponProficiency(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Exotic Weapon Proficiency(" + feat.Property + ")";
            feat.FType = "General";
            feat.Content = "Chose a type of exotic weapon, such as dire flail or shuriken. You understand how to use that type of exotic weapon in combat.";
            feat.Prerequisite.Add(RequiredBAB(1));
            feat.Prerequisite.Add("(plus Str 13 for bastard sword or dwarven waraxe)");
            feat.Benefit = "You make attack rolls with the weapon normally.";
            feat.NormalWithout = "A character who uses a weapon with which he or she is not proficient takes a -4 penalty on attack rolls.";
            feat.Special = "You can gain Exotic Weapon Proficiency multiple times. Each time you you the feat, it applies to a new type of exotic weapon. Proficiency with the bastard sword or the dwarven waraxe has an additional prerequisite of Str 13.\r\nA fighter may select Exotic Weapon Proficiency as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            feat.Multiple = true;
            return feat;
        }
        public Feat ExtendSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Extend Spell";
            feat.FType = "Metamagic";
            feat.Content = "You can cast spells that last longer than normal.";
            feat.Benefit = "An extended spell lasts twice as long as normal. A spell with a duration of concentration, instantaneous or permanent is not affected by this feat. An extended spell uses up a spell slot one level higher than the spell's actual level.";
            return feat;
        }
        public Feat ExtraTurning()
        {
            Feat feat = new Feat();
            feat.Name = "Extra Turning";
            feat.FType = "General";
            feat.Content = "You can turn or rebuke cretures more often than normal.";
            feat.Prerequisite.Add("Ability to turn or rebuke creatures.");
            feat.Benefit = "Each time you take this feat, you can use your ability to turn or rebuke creatures four more times per day than normal.\r\nIf you have the ability to turn or rebuke more than one kind of creature (such as a good-aligned cleric with access to the fire domain, who can turn undead and water creatures and fire creatuers), each of your turning or rebuking abilities gains four additional uses per day.";
            feat.NormalWithout = "Without this feat, a character can typically turn or rebuke undead (or other creatures) a number of times per day equal to 3 + his or her Charisma modifier.";
            feat.Special = "You can gain Extra Turning multiple times. Its effects stack. Each time you take the feat, you can use each of your turning or rebuking abilities four additional times per day.";
            feat.Multiple = true;
            return feat;
        }

        #endregion
        #region F
        public Feat FarShot()
        {
            Feat feat = new Feat();
            feat.Name = "Far Shot";
            feat.FType = "General";
            feat.Content = "You can get greater distance out of a ranged weapon.";
            feat.Prerequisite.Add(PointBlankShot());
            feat.Benefit = "When you use a projectil weapon, such as a bow, its range increment increases by one-half (multiply by 1-1/2). When you use a thrown weapon, its range increment is doubled.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ForgeRing()
        {
            Feat feat = new Feat();
            feat.Name = "Forge Ring";
            feat.FType = "Item Creation";
            feat.Content = "You can create magic rings, which have varied magical effects.";
            feat.Prerequisite.Add("Caster level 12th.");
            feat.Benefit = "You can create any ring whose prerequisites you meet. Crafting a ring takes one day for each 1,000 gp in its base price. To craft a ring, you must spend 1/25 of its base price in XP and use up raw materials costing one-half of its base price. \r\nYou can also mend a broken ring if it is one that you could make. Doing so costs half the XP, half the raw materials, and half the time it would take to forge that ring in the first place.\r\nSome magic rings incur extra costs in material components or XP, as noted in their descriptions. For example, a ring of three wishes costs 15,000 XP in addition to costs derived from its base price (as many XP as it costs to cast wish three times). You must pay such a cost to forge such a ring or to mend a broken one.";
            return feat;
        }
        #endregion
        #region G
        public Feat GreatCleave()
        {
            Feat feat = new Feat();
            feat.Name = "Great Cleave";
            feat.FType = "General";
            feat.Content = "You can wield a melee weapon with such power that you can strike multiple times when you fell your foes.";
            feat.Prerequisite.Add(RequiredStat(1, 13));
            feat.Prerequisite.Add(Cleave());
            feat.Prerequisite.Add(PowerAttack());
            feat.Prerequisite.Add(RequiredBAB(4));
            feat.Benefit = "This feat works like Cleave, except that there is no limit to the number of times you can use it per round.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat GreatFortitude()
        {
            Feat feat = new Feat();
            feat.Name = "Great Fortitude";
            feat.FType = "General";
            feat.Content = "You are tougher than normal.";
            feat.Benefit = "You get a +2 bonus on all Fortitude saving throws.";
            return feat;
        }
        public Feat GreaterSpellFocus(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Greater Spell Focus(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Chose a school of magic yo which you already have applied the Spell Focus feat. Your spells of that school are now even more potent than before.";
            feat.Prerequisite.Add(SpellFocus("Chosen school"));
            feat.Benefit = "Add +1 to the Difficulty Class for all saving throws against spells from the school of magic you select. THis bonus stacks with the bonus from Spell Focus.";
            feat.Special = "You can gain this feat multiple times. Its effects do not stack. Each time you take the feat, it applies to a new school of magic to which you already have applied the Spell Focus feat.";
            feat.Multiple = true;
            return feat;
        }
        public Feat GreaterSpellPenetration()
        {
            Feat feat = new Feat();
            feat.Name = "Greater Spell Penetration";
            feat.FType = "General";
            feat.Content = "Your spells are remarkably potent, breaking through spell resistance more readily than normal.";
            feat.Prerequisite.Add(SpellPenetration());
            feat.Benefit = "You get a +2 bonus on caster level checks (1d20 + caster level) made to overcome a creature's spell penetration. This bonus stacks with the one from Spell Penetration.";
            return feat;
        }
        public Feat GreaterTwoWeaponFighting()
        {
            Feat feat = new Feat();
            feat.Name = "Greater Two-Weapon Fighting";
            feat.FType = "General";
            feat.Content = "You are a master at fighting two-handed.";
            feat.Prerequisite.Add(RequiredStat(2, 19));
            feat.Prerequisite.Add(ImprovedTwoWeaponFighting());
            feat.Prerequisite.Add(TwoWeaponFighting());
            feat.Prerequisite.Add(RequiredBAB(11));
            feat.Benefit = "You get a third attack with your off-hand weapon, albeit at a -10 penalty.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feat.\r\nAn 11th-level ranger who has chosen the two-weapon combat style is treated as having " + feat.Name + ", even if he does not have the prerequisites for it, but only when he is wearing light or no armor.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat GreaterWeaponFocus(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Greater Weapon Focus(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose one type of weapon, such as greataxe, for which you have already selected Weapon Focus. You can also choose unarmed strike or grapple as your weapon for purposes of this feat. You are especially good at using this weapon.";
            feat.Prerequisite.Add("Proficiency with selected weapon.");
            feat.Prerequisite.Add(WeaponFocus(_prop));
            feat.Prerequisite.Add("Fighter level 8th");
            feat.Benefit = "You gain a +1 bonus on all attack rolls you make using the selected weapon. This bonus stacks with other bonuses on attack rolls, including the one from Weapon Focus.";
            feat.Special = "You can gain " + feat.Name + " multiple times. Its effects do not stack. Each time you take the feat, it applies to a new type of weapon.\r\nA fighter must have " + feat.Name + " with a given weapon to gain the Greater Weapon Specialization feat for that weapon.\r\nA fighter may select " + feat.Name + " as on of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            feat.Multiple = true;
            return feat;
        }
        public Feat GreaterWeaponSpecialization(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Greater Weapon Specialization(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose one type of weapon, such as greataxe, for which you have already selected Weapon Specialization. You can also choose unarmed strike or grapple as you weapon for purposes of this feat. You deal extra damage when using this weapon.";
            feat.Prerequisite.Add("Proficiency with selected weapon.");
            feat.Prerequisite.Add(GreaterWeaponFocus(_prop));
            feat.Prerequisite.Add(WeaponFocus(_prop));
            feat.Prerequisite.Add(WeaponSpecialization(_prop));
            feat.Prerequisite.Add("Fighter level 12th");
            feat.Benefit = "you gain a +2 bonus on all damage rolls you make using the selected weapon. This bonus stacks with other bonuses on damage rolls, including the one one from Weapon Specialization.";
            feat.Special = "You can gain " + feat.Name + " multiple times. Its effects do not stack. Each time you take the feat, it applies to a new type of weapon.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.Multiple = true;
            return feat;
        }
        #endregion
        #region H
        public Feat HeightenSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Heighten Spell";
            feat.FType = "Metamagic";
            feat.Content = "You cast a spell as if it were a higher-level spell than it actually is.";
            feat.Benefit = "A heightened spell has a higher spell level than normal (up to maximum of 9th level). Unlike other metamagic feats, " + feat.Name + " actually increases the effective level of the spell that it modifies. All effects dependent on spell level (such as saving throw DCs and ability to penetrate a lesser globe of invulnerability) are calculated according to the heightened level. The heightened spell is as difficult to prepare and cast as a spell of its effective level. For example, a cleric could prepare hold person as a 4th-level spell (instead of a 2nd level spell), and it would in all ways be treated as a 4th-level spell.";
            return feat;
        }
        #endregion
        #region I
        public Feat ImprovedBullRush()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Bull Rush";
            feat.FType = "General";
            feat.Content = "You know ho to push opponents back.";
            feat.Prerequisite.Add(RequiredStat(1, 13));
            feat.Prerequisite.Add(PowerAttack());
            feat.Benefit = "When you perform a bull rush, you do no provoke attack of opportunity from the defender. You also gain a +4 bonus on the opposed Strength check you make to push back the defender.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedCounterspell()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Counterspell";
            feat.FType = "General";
            feat.Content = "You understand the nuances of magic to such an extent that you can counter your opponent's spell with great efficiency.";
            feat.Benefit = "When counterspelling, you may use a spell of the same school that is one or more spell levels higher than the target spell.";
            feat.NormalWithout = "Without this feat, you may counter a spell only with the same spell or with a spell specifically designated as countering the target spell.";
            return feat;
        }
        public Feat ImprovedCritical(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Improved Critical(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose one type of weapon, such as longsword or greataxe. With that weapon you know how to hit where it hurts.";
            feat.Prerequisite.Add("Proficient with the weapon");
            feat.Prerequisite.Add(RequiredBAB(8));
            feat.Benefit = "When using the weapon you selected, your threat range is doubled. For example a longsword usually threatens a critical hit on a roll of 19-20 (two numbers). If a character using a longsword has Improved Critical(longsword), the threat range becomes 17-20(four numbers).";
            feat.Special = "You can gain Improved Critical multiple times. The effects do not stack. Each time you take the feat, it applies to a new type of weapon.\r\nThis effect doesn't stack with any other effect that expands the threat range of a weapon (such as the keen edge spell).\r\nA fighter may select Improved Critical as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            feat.Multiple = true;
            return feat;
        }
        public Feat ImprovedFeint()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Feint";
            feat.FType = "General";
            feat.Content = "You are skilled at misdirecting your opponents attention in combat.";
            feat.Prerequisite.Add(RequiredStat(4, 13));
            feat.Prerequisite.Add(CombatExpertise());
            feat.Benefit = "You can make a Bluff check to feint in combat as a move action.";
            feat.NormalWithout = "Feinting in combat is a standard action.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedGrapple()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Grapple";
            feat.FType = "General";
            feat.Content = "You are skilled at grappling opponents.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(ImprovedUnarmedStrike());
            feat.Benefit = "You do not provoke an attack of opportunity when you make a touch attack to start a grapple. You also gain a +4 bonus on all grapple checks regardless of whether you started the grapple.";
            feat.NormalWithout = "Without this feat, you provoke an attack of opportunity when you make a touch attack to start a grapple.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.\r\nA monk may select " + feat.Name + " as a bonus feat at 1st level, even if she does not meet the prerquisites.";
            feat.ClassBonus.Add("Fighter");
            feat.ClassBonus.Add("Monk");
            return feat;
        }
        public Feat ImprovedInitiative()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Initiative";
            feat.FType = "General";
            feat.Content = "You can react more quickly than normal in a fight.";
            feat.Benefit = "You get a +4 bonus on initiative checks.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedOverrun()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Overrun";
            feat.FType = "General";
            feat.Content = "You are skilled at knocking down opponents.";
            feat.Prerequisite.Add(RequiredStat(1, 13));
            feat.Prerequisite.Add(PowerAttack());
            feat.Benefit = "When you attempt to overrun an opponent, the target may not choose to avoid you. You also gain a +4 bonus on your Strength check to knock down your opponent.";
            feat.NormalWithout = "Without this feat, the target of an overrun can choose to avoid you or block you.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedPreciseShot()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Precise Shot";
            feat.FType = "General";
            feat.Content = "Your ranged attacks can ignore the effects of cover or concealment.";
            feat.Prerequisite.Add(RequiredStat(2, 19));
            feat.Prerequisite.Add(PointBlankShot());
            feat.Prerequisite.Add(PreciseShot());
            feat.Prerequisite.Add(RequiredBAB(11));
            feat.Benefit = "Your ranged attacks ignore the AC bonus granted to targets by anything less than total cover, and the miss chance granted to targets by anything less than total concealment. Total cover and total concealment provide their normal benefits against your ranged attacks.\r\nIn addition, when you shoot or throw ranged weapons at a grappling opponent, you automatically strike at the opponent you have chosen.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.\r\nAn 11th-level ranger who has chosen the archery combat style is treated as have " + feat.Name + ", even if he does not have the prerequisites for it but only when he is wearing light or no armor.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedShieldBash()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Shield Bash";
            feat.FType = "General";
            feat.Content = "You can bash with a shield while retaining its shield bonus to your Armor Class.";
            feat.Prerequisite.Add(ShieldProficiency());
            feat.Benefit = "When you perform a shield bash, you may still apply the shield's bonus to your AC.";
            feat.NormalWithout = "Without this feat, a character who performs a shield bash loses the shield's bonus to AC until his or her next turn.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedSunder()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Sunder";
            feat.FType = "General";
            feat.Content = "You are skilled at attacking your opponents' weapons and shields, as well as other objects.";
            feat.Prerequisite.Add(RequiredStat(1, 13));
            feat.Prerequisite.Add(PowerAttack());
            feat.Benefit = "When you strike at an object held or carried by an opponent (such as a weapon or shield), you do not provoke an attack of opportunity.\r\nYou also gain a +4 bonus on any attack roll made to attack an object held or carried by another character.";
            feat.NormalWithout = "Without this feat, you provoke an attack of opportunity when you strike at an object held or carried by another character.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedTrip()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Trip";
            feat.FType = "General";
            feat.Content = "You are trained not only in tripping opponents safely but also in following through with an attack.";
            feat.Prerequisite.Add(RequiredStat(4, 13));
            feat.Prerequisite.Add(CombatExpertise());
            feat.Benefit = "You do not provoke an attack of opportunity when you attempt to trip an opponent while you are unarmed. You also gain a +4 bonus on your Strength check to trip your opponent.\r\nIf you trip an opponent in melee combat, you immediately get a melee attack against that opponent as if you hadn't used your attack for the trip attempt. For example, at 11th level, Tordek get three attacks at bonuses of +11, +6 and +1. In the current round, he attempts to trip his opponent. His first attempt fails (using up his first attack). His second attempt succeds, and he immediately makes a melee attack against his opponent with a bonus of +6. Finally, he takes his last attack at a bonus of +1.";
            feat.NormalWithout = "Without this feat, you provoke an attack of opportunity when you attempt to trip an oppenent while you are unarmed.";
            feat.Special = "At 6th level, a monk may select " + feat.Name + " as a bonus feat, even if she does not have the prerequisites.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            feat.ClassBonus.Add("Monk");
            return feat;
        }
        public Feat ImprovedTurning()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Turning";
            feat.FType = "General";
            feat.Content = "Your turning or rebuking attempts are more powerful than normal.";
            feat.Prerequisite.Add("Ability to turn or rebuke creatures.");
            feat.Benefit = "You tun or rebuke creatures as if you were one level higher than you are in the class that grants you the ability.";
            return feat;
        }
        public Feat ImprovedTwoWeaponFighting()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Two-Weapon Fighting";
            feat.FType = "General";
            feat.Content = "You are an expert in fighting two-handed.";
            feat.Prerequisite.Add(RequiredStat(2, 17));
            feat.Prerequisite.Add(TwoWeaponFighting());
            feat.Prerequisite.Add(RequiredBAB(6));
            feat.Benefit = "In addition to the standard single extra attack you get with an off-hand weapon, you get a second attack with it, albeit at a -5 penalty.";
            feat.NormalWithout = "Without this feat, you can only get a single extra attack with an off-hand weapon.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feat.\r\nAn 6th-level ranger who has chosen the two-weapon combat style is treated as having " + feat.Name + ", even if he does not have the prerequisites for it, but only when he is wearing light or no armor.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat ImprovedUnarmedStrike()
        {
            Feat feat = new Feat();
            feat.Name = "Improved Unarmed Strike";
            feat.FType = "General";
            feat.Content = "You are skilled at fighting while unarmed.";
            feat.Benefit = "You are considered to armed even when unarmed - this is, you do not provoke attacks of opportunity from armed opponents when you attack them while unarmed. However, you stell get an attack of opportunity against an opponent who makes an unarmed attack on you.\r\nIn addition, your unarmed strikes can deal lethal or nonlethal damage, at your option.";
            feat.NormalWithout = "Without this feat, you are considered unarmed when attacking with an unarmed strike, and you can deal only nonlethal damage with such an attack.";
            feat.Special = "A monk automatically gains " + feat.Name + " as a bonus feat at 1st level. She need not select it.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feat.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat Investigator()
        {
            Feat feat = new Feat();
            feat.Name = "Investigator";
            feat.FType = "General";
            feat.Content = "You have a knack for finding information.";
            feat.Benefit = "You get a +2 bonus on all Gather Information checks and Search checks.";
            return feat;
        }
        public Feat IronWill()
        {
            Feat feat = new Feat();
            feat.Name = "Iron Will";
            feat.FType = "General";
            feat.Content = "You have astronger will than normal";
            feat.Benefit = "You get a +2 bonus on all Will saving throws.";
            return feat;
        }
        #endregion
        #region L
        public Feat Leadership()
        {
            Feat feat = new Feat();
            feat.Name = "Leadership";
            feat.FType = "General";
            feat.Content = "You are the sort of person others want to follow, and you have done som work attempting to recruit cohorts and followers.";
            feat.Prerequisite.Add("Character level 6th.");
            feat.Benefit = "You can attract loyal companions and devoted followers, subordinates who assist you. Your DM has information on what sort of cohort and how many followers you can recruit.";
            feat.Special = "Check with you DM before selecting this feat, and work with you DM to determine an approrpiate cohort and followers for your character.";
            return feat;
        }
        public Feat LightningReflexes()
        {
            Feat feat = new Feat();
            feat.Name = "Lightning Reflexes";
            feat.FType = "General";
            feat.Content = "You have faster than normal reflexes.";
            feat.Benefit = "You get a +2 bonus on all Reflex saving throws.";
            return feat;
        }
        #endregion
        #region M
        public Feat MagicalAptitude()
        {
            Feat feat = new Feat();
            feat.Name = "Magical Aptitude";
            feat.FType = "General";
            feat.Content = "You have a knack for magical endeavors.";
            feat.Benefit = "You get a +2 bonus on all Spellcraft checks and Use Magic Device checks.";
            return feat;
        }
        public Feat Manyshot()
        {
            Feat feat = new Feat();
            feat.Name = "Manyshot";
            feat.FType = "General";
            feat.Content = "You can fire multiple arrows simultaneously against a nearby target.";
            feat.Prerequisite.Add(RequiredStat(2, 17));
            feat.Prerequisite.Add(PointBlankShot());
            feat.Prerequisite.Add(RapidShot());
            feat.Prerequisite.Add(RequiredBAB(6));
            feat.Benefit = "As a standard action, you may fire two arrows at a single opponent within 30 feet. BOth arrows use the same attack roll (with a -4 penalty) to determine success and deal damage normally (but see Special).\r\nFor every five points of base attack bonus you have above +6, you may add one additional arrow to this attack, to a maximum of four arrows at a base attack bonus of +16. However each arrow after the second adds a cumulative -2 penalty on the attack roll (for a total penalty of -6 for three arrows and -8 for four).\r\nDamage reduction and other resistances apply separately against each arrow fired.";
            feat.Special = "Regardless of the number of arrows you fire, you apply precision based damage (such as sneak attack damage) only once. If you score a critical hit, only the first arrow fired deals critical damage; all others deal regular damage.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feats.\r\nA 6th level ranger who has chosen the archery combat style is treated as having " + feat.Name + " even if he does not have the prerequisites for it, but only when he is wearing light or no armor.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat MartialWeaponProficiency(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Martial Weapon Proficiency(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose a type of martial weapon, such as a longbow. You understand how to use that type of martial weapon in combat. Use this feat to expand the list of weapons with which you are proficient beyond the basic list in you class description.";
            feat.Benefit = "You make attack rolls with the selected weapon normally.";
            feat.NormalWithout = "When using a weapon with which you are not proficient, you take a -4 penalty on attack rolls.";
            feat.Special = "Barbarians, fighters, paladins, and rangers are proficient with all martial weapons. They need not select this feat.\r\nYou can gain Martial Weapon Proficiency multiple times. Each time you take the feat, it applies to a new type of weapon.\r\nA cleric who chooses the War domain automatically gains the Martial Weapon Proficiency feat related to his deity’s favored weapon as a bonus feat, if the weapon is a martial one. He need not select it. \r\nA sorcerer or wizard who casts the spell Tenser’s transformation on himself or herself gains proficiency with all martial weapons for the duration of the spell.";
            feat.Multiple = true;
            return feat;
        }
        public Feat MaximizeSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Maximize Spell";
            feat.FType = "Metamagic";
            feat.Content = "You can cast spells to maximum effect.";
            feat.Benefit = "All variable, numeric effects of a spell modified by this feat are maximized. A maximized spell deals maximum damage, cures the maximum number of hit points, affects the maximum number of targets etc., as appropriate. For example, a maximized fireball deals 6 points of damage per caster level (up to a maximum of 60 points of damage at 10th caster level). Saving throws and opposed rolls (such as the one you make when you cast dispel magic) are not affected, nor are the spells without random variables. A maximized spell uses up a spell slot three levels higher than the spell's actual level.\r\nAn empowered, maximized spell gains the separate benefits of each feat: maximum result plus one-half the normally rolled result. An empowered, maximized fireball cast by a 15-level wizard deals points of damage equal to 60 plus one half of 10d6.";
            return feat;
        }
        public Feat Mobility()
        {
            Feat feat = new Feat();
            feat.Name = "Mobility";
            feat.FType = "General";
            feat.Content = "You are skilled at dodging past opponents and avoiding blows.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(Dodge());
            feat.Benefit = "You get a +4 dodge bonus to Armor Class against attacks of opportunity caused when you move out of or within a threatened area. A condition that makes you lose your Dexterity bonus to Armor Class (if any) also makes you lose dodge bonuses. Dodge bonuses (such as this one and a dwarf's racial bonus on dodge attempts against giants) stack with each other, unlike moste types of bonuses.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat MountedArchery()
        {
            Feat feat = new Feat();
            feat.Name = "Mounted Archery";
            feat.FType = "General";
            feat.Content = "You are skilled at using ranged weapons while mounted.";
            feat.Prerequisite.Add(RequiredSkill("Ride", 1));
            feat.Prerequisite.Add(MountedCombat());
            feat.Benefit = "The penalty you take when using a ranged weapon while mounted is halved: -2 instead of -4 if your mount is taking a double move, and -4 instead of -8 if your mount is running.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat MountedCombat()
        {
            Feat feat = new Feat();
            feat.Name = "Mounted Combat";
            feat.FType = "General";
            feat.Content = "You are skilled in mounted combat.";
            feat.Prerequisite.Add(RequiredSkill("Ride", 1));
            feat.Benefit = "Once per round when your mount is hit in combat, you may attempt a Ride check (as a reaction) to negate the hit. The hit is negated if your Ride check result is greater than the opponent's attack roll. (Essentially, the Ride check result becomes the mounts Armor Class if its higher than the mount's regular AC.)";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        #endregion
        #region N
        public Feat NaturalSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Natural Spell";
            feat.FType = "General";
            feat.Content = "You can cast spells while in a wild shape.";
            feat.Prerequisite.Add(RequiredStat(5, 13));
            feat.Prerequisite.Add("Wild shape ability");
            feat.Benefit = "You can complete the verbal and somatic components of spells while in a wild shape. For example, while in hte form of a hawk you could substitue schreeches and gestures with your talons for the normal verbal and somatic components of a spell. You can also use any material components or focuses you posses, even if such items are melded within your current form. This feat does not permit the use of magic items while you are in a form that could not ordinarily use them, and you do not gain the ability to speak while in a wild shape.";
            return feat;
        }
        public Feat Negotiator()
        {
            Feat feat = new Feat();
            feat.Name = "Negotiator";
            feat.FType = "General";
            feat.Content = "You are good at gauging and swaying attitudes.";
            feat.Benefit = "You get a +2 bonus on all Diplomacy checks and Sense Motive checks.";
            return feat;
        }
        public Feat NimbleFingers()
        {
            Feat feat = new Feat();
            feat.Name = "Nimble Fingers";
            feat.FType = "General";
            feat.Content = "You are adept at manipulating small, delicate objects.";
            feat.Benefit = "You get a +2 bonus on all Disable Device checks and Open Lock checks.";
            return feat;
        }
        #endregion
        #region P
        public Feat Persuasive()
        {
            Feat feat = new Feat();
            feat.Name = "Persuasive";
            feat.FType = "General";
            feat.Content = "You have a way with words and body language.";
            feat.Benefit = "You get a +2 bonus on all Bluff checks and Intimidate checks.";
            return feat;
        }
        public Feat PointBlankShot()
        {
            Feat feat = new Feat();
            feat.Name = "Point Blank Shot";
            feat.FType = "General";
            feat.Content = "You are skilled at making well-placed shots with ranged weapons at close range.";
            feat.Benefit = "You get a +1 bonus on attack and damage rolls with ranged weapons at ranges of up to 30 feet.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat PowerAttack()
        {
            Feat feat = new Feat();
            feat.Name = "Power Attack";
            feat.FType = "General";
            feat.Content = "You can make exceptionally powerful melee attacks.";
            feat.Prerequisite.Add(RequiredStat(1, 13));
            feat.Benefit = "On your action, before making attacks rolls for a round, you may choose to subtract a number from all melee attack rolls and add the same number to all melee damage rolls. This number may not exceed your base attack bonus. The penalty on attacks and bonus on damage apply until your next turn.";
            feat.Special = "If you attack with a two-handed weapon or with a one-handed weapon wielded in two hands, instead add twice the number substracted from your attack rolls. You can't add the bonus from " + feat.Name + " to the damage dealt with a light weapon (except with unarmed strikes or natural weapon attacks), even though the penalty on attack rolls still applies. (Normally, you treat a double weapon as a one-handed weapon and a light weapon. If you choose to use a double weapon like a two-handed weapon, attack with only one end of it in a round, you treat it as a two-handed weapon.)\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat PreciseShot()
        {
            Feat feat = new Feat();
            feat.Name = "Precise Shot";
            feat.FType = "General";
            feat.Content = "You are skilled at timing and aiming ranged attacks.";
            feat.Prerequisite.Add(PointBlankShot());
            feat.Benefit = "You can shoot or throw ranged weapons at an opponent engaged in melee without taking the standard -4 penalty on your attack roll.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        #endregion
        #region Q
        public Feat QuickDraw()
        {
            Feat feat = new Feat();
            feat.Name = "Quick Draw";
            feat.FType = "General";
            feat.Content = "You can draw weapons with startling speed.";
            feat.Benefit = "You can draw a weapon as a free action instead of as a move action. You can draw a hidden weapon as a move action.\r\nA character who has selected this feat may throw weapons at his full normal rate of attacks (much like a character with a bow).";
            feat.NormalWithout = "Without this feat, you may draw a weapon as a move action or (if your base attack bonus is +1 or higher) as a free action as part of movement. Without this feat, you can draw a hidden weapon as a standard action.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat QuickenSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Quicken Spell";
            feat.FType = "Metamagic";
            feat.Content = "You can cast a spell with a moment's thought.";
            feat.Benefit = "Casting a quickened spell is a free action. You can perform another action, even casting another spell, in the same round as you cast a quickened spell. You may cast only one quickened spell per round. A spell whose casting time is more than 1 full-round action cannot be quickened. A quickened spell uses upa spell slot four levels higher than the spell's actual level. Casting a quickened spell doesn't provoke an attack of opportunity.";
            feat.Special = "This feat can't be applied to any spell cast spontaneously (including sorcere spells, bard spells, and cleric or druid spells cast spontaneously), since applying metamagic feat to a spontaneously cast spell automatically increases the casting time to a full-round action.";
            return feat;
        }
        #endregion
        #region R
        public Feat RapidReload(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Rapid Reload(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose a type of crossbow (hand, light or heavy). You can reload a crossbow of that type more quickly than normal.";
            feat.Benefit = "The time required for you to reload your chosen type of crossbow is reduced to a free action (for a hand or light crossbow) or a move action (for a heavy crossbow). Reloading a crossbow still provokes an attack of opportunity.\r\nIf you have selected this feat for hand crossbow or light crossbow, you may fire that weapon as many times in a full attack action as you could attack if you were using a bow.";
            feat.NormalWithout = "A character without this feat needs a move action to reload a hand or light crossbow, or a full-round action to reload a heavy crossbow.";
            feat.Special = "You can gain Rapid Reload multiple times. Each time you take the feat, it applies to a new type of crossbow.\r\nA fighter may select Rapid Reload as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat RapidShot()
        {
            Feat feat = new Feat();
            feat.Name = "Rapid Shot";
            feat.FType = "General";
            feat.Content = "You can use ranged weapon with exceptional speed.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(PointBlankShot());
            feat.Benefit = "You can get one extra attack per round with a ranged weapon. The attack is at your highest base attack bonus, but each attack you make in that round (the extra one and the normal ones) take a -2 penalty. You must use the full attack action to use this feat.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.\r\nA 2nd-level ranger who has chosen the archery combat style is treated as having " + feat.Name + ", even if he does not have the prerequisites for it, but only when he is wearing light or no armor.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat RideByAttack()
        {
            Feat feat = new Feat();
            feat.Name = "Ride-By Attack";
            feat.FType = "General";
            feat.Content = "You are skilled at making fast attacks for your mount.";
            feat.Prerequisite.Add(RequiredSkill("Ride", 1));
            feat.Prerequisite.Add(MountedCombat());
            feat.Benefit = "When you are mounted and use the charge action, you may move and attack as if with a standard charge and then move again (continuing the straight line of the charge). Your total movement for the round can't exceed double your mounted speed. You and your mount do not provoke attack of opportunity from the opponent that you attack.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat Run()
        {
            Feat feat = new Feat();
            feat.Name = "Run";
            feat.FType = "General";
            feat.Content = "You are fleet of foot.";
            feat.Benefit = "When running, you move five times your normal speed (if wearing light or no armor and carrying no more than a light load) or four times your speed (if wearing medium or heavy armor or carrying a medium or heavy load). If you make a jump after a running start, you gain a +4 bonus on your Jump check. While running, you retain your Dexterity bonus to AC.";
            feat.NormalWithout = "You move four times your speed while running (if wearing light or no armor and carrying no more than a light load) or three times your speed (if wearing medium or heavy armor or carrying a medium or heavy load), and you lose your Dexterity bonus to AC.";
            return feat;
        }
        #endregion
        #region S
        public Feat ScribeScroll()
        {
            Feat feat = new Feat();
            feat.Name = "Scribe Scroll";
            feat.FType = "Item Creation";
            feat.Content = "You can create scrolls, from which you or another spellcaster can cast the scribed spells.";
            feat.Prerequisite.Add("Caster level 1st");
            feat.Benefit = "You can create a scroll of any spell that you know. Scribing a scroll takes one day for each 1000 gp in its base price. The base price of a scroll is its spell level x its caster level x 25 gp. To scribe a scroll, you must spend 1/25 of this base price in XP and use up raw materials costing one-half of this base price.\r\nAny scroll that stores a spell with a costly material component or an XP cost also carries a commensurate cost. In addition to the costs derived from the base price, you must expend the material component or pay the XP when scribing the scroll.";
            return feat;
        }
        public Feat SelfSufficient()
        {
            Feat feat = new Feat();
            feat.Name = "Self-Sufficient";
            feat.FType = "General";
            feat.Content = "You can take care of yourself in harsh environments and situations.";
            feat.Benefit = "You get a +2 bonus on all Heal checks and Survival checks.";
            return feat;
        }
        public Feat ShieldProficiency()
        {
            Feat feat = new Feat();
            feat.Name = "Shield Proficiency";
            feat.FType = "General";
            feat.Content = "You are proficient with bucklers, small shields and large shields.";
            feat.Benefit = "You can use a shield and take only the standard penalties.";
            feat.NormalWithout = "When you are using a shield with which you are not proficient, you take the shield's armor check penalty on attack rolls and on all skill checks that involve moving, including Ride checks.";
            feat.Special = "Barbarians, bards, clerics, druids, fighters, paladins and rangers automatically have " + feat.Name + " as a bonus feat. They need not select it.";
            return feat;
        }
        public Feat ShootOnTheRun()
        {
            Feat feat = new Feat();
            feat.Name = "Shot on the Run";
            feat.FType = "General";
            feat.Content = "You are highly trained in skirmish ranged weapon tactics.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(Dodge());
            feat.Prerequisite.Add(Mobility());
            feat.Prerequisite.Add(PointBlankShot());
            feat.Prerequisite.Add(RequiredBAB(4));
            feat.Benefit = "When using the attack action with a ranged weapon, you can move both before and after the attack, provided that your total distance moved is not greater than your speed.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat SilentSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Silent Spell";
            feat.FType = "Metamagic";
            feat.Content = "You can cast spells silently.";
            feat.Benefit = "A silent spell can be cast with no verbal components. Spells without verbal components are not affected. A silent spell uses up a spell slot one level higher than the spell's actual level.";
            feat.Special = "Bard spells cannot be enhanced by this metamagic feat.";
            return feat;
        }
        public Feat SimpleWeaponProficiency()
        {
            Feat feat = new Feat();
            feat.Name = "Simple Weapon Proficiency()";
            feat.FType = "General";
            feat.Content = "You understand how to use all types of simple weapons in combat.";
            feat.Benefit = "You make attack rolls with simple weapons normally.";
            feat.NormalWithout = "When using a weapon with which you are not proficient, you take a -4 penalty on attack rolls.";
            feat.Special = "All characters except for druids, monks, rogues and wizards are automatically proficient with all simple weapons. They need not select this feat.\r\nA sorcere or wizard who casts the spell Tenser's transformation on himself or herself gains proficiency with all simple weapons for the duration of the spell.";
            return feat;
        }
        public Feat SimpleWeaponProficiency(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Simple Weapon Proficiency(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "You understand how to use all types of simple weapons in combat.";
            feat.Benefit = "You make attack rolls with simple weapons normally.";
            feat.NormalWithout = "When using a weapon with which you are not proficient, you take a -4 penalty on attack rolls.";
            feat.Special = "All characters except for druids, monks, rogues and wizards are automatically proficient with all simple weapons. They need not select this feat.\r\nA sorcere or wizard who casts the spell Tenser's transformation on himself or herself gains proficiency with all simple weapons for the duration of the spell.";
            feat.Multiple = true;
            return feat;
        }
        public Feat SkillFocus(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "SKill Focus(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose a skill, such as Move Silently. You have a special knack with that skill.";
            feat.Benefit = "You get a +3 bonus on all checks involving that skill.";
            feat.Special = "You can gain this feat multiple times. Its effects do not stack. Each time you take the feat, it applies to a new skill.";
            return feat;
        }
        public Feat SnatchArrows()
        {
            Feat feat = new Feat();
            feat.Name = "Snatch Arrows";
            feat.FType = "General";
            feat.Content = "You are adept at grabbing incoming arrows, as well as crossbow bolts, spears and other projectile or thrown weapons.";
            feat.Prerequisite.Add(RequiredStat(2, 15));
            feat.Prerequisite.Add(DeflectArrows());
            feat.Prerequisite.Add(ImprovedUnarmedStrike());
            feat.Benefit = "When using the Deflect Arrows feat, you may catch the weapon instead of just deflecting it. Thrown weapons, such as spears or axes, can immediately be thrown back at the original attacker (even though it isn't your turn) or kept for later use.\r\nYou must have at least one hand free (Holding nothing) to use this feat.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat SpellFocus(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Spell Focus(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose a school of magic, such as illusion. Your spells of that school are more potent than normal.";
            feat.Benefit = "Add +1 to the Difficulty Class for all saving throws against spells from the school of magic you select.";
            feat.Special = "You can gain this feat multiple times. Its effects do not stack. Each time you take the feat, it applies to a new school of magic.";
            feat.Multiple = true;
            return feat;
        }
        public Feat SpellMastery()
        {
            Feat feat = new Feat();
            feat.Name = "Spell Mastery";
            feat.FType = "Special";
            feat.Content = "You are so intimately familiar with certain spells that you don't need a spellbook to prepare them anymore.";
            feat.Prerequisite.Add("Wizard level 1st");
            feat.Benefit = "Each time you take this feat choose a number of spells equal to your Intelligence modifier that you already know. From that point on, you can prepare these spells without referring to a spellbook.";
            feat.Special = "Without this feat, you must use a spellbook to prepare all your spells, except read magic.";
            return feat;
        }
        public Feat SpellPenetration()
        {
            Feat feat = new Feat();
            feat.Name = "Spell Penetration";
            feat.FType = "General";
            feat.Content = "Your spells are especially potent, breaking throuch spell resistance more readily than normal.";
            feat.Benefit = "You get a +2 bonus on caster level checks (1d20 + caster level) made to overcome a creatures spell resistance.";
            return feat;
        }
        public Feat SpiritedCharge()
        {
            Feat feat = new Feat();
            feat.Name = "Spirited Charge";
            feat.FType = "General";
            feat.Content = "You are trained at making a devastating mounted charge.";
            feat.Prerequisite.Add(RequiredSkill("Ride", 1));
            feat.Prerequisite.Add(MountedCombat());
            feat.Prerequisite.Add(RideByAttack());
            feat.Benefit = "When mounted and using the charge action, you deal double damage with a melee weapon (or triple damage with a lance).";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat SpringAttack()
        {
            Feat feat = new Feat();
            feat.Name = "Spring Attack";
            feat.FType = "General";
            feat.Content = "You are trained in fast melee attacks and fancy footwork.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(Dodge());
            feat.Prerequisite.Add(Mobility());
            feat.Prerequisite.Add(RequiredBAB(4));
            feat.Benefit = "When using the attack action with a melee weapon, you can move both before and after the attack, provided that your total distance moved is not greater than your speed. Moving in this way does not provoke an attack of opportunity from the defender you attack, though it might provoke attacks of opportunity from other creatures, if appropriate. You can't use this feat if you are wearing heavy armor.\r\nYou must move at least 5 feet both before and after you make your attack in order to utilize the benefits of Spring Attack.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat Stealthy()
        {
            Feat feat = new Feat();
            feat.Name = "Stealthy";
            feat.FType = "General";
            feat.Content = "You are particularly good at avoiding notice.";
            feat.Benefit = "You get a +2 bonus on all Hide checks and Move Silently checks.";
            return feat;
        }
        public Feat StillSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Still Spell";
            feat.FType = "General";
            feat.Content = "You can cast spells without gestures.";
            feat.Benefit = "A stilled spell can be cast with no somatic components. Spells without somatic components are not affected. A stilled spell uses up a spell slot one level higher thant the spell's actual level.";
            return feat;
        }
        public Feat StunningFist()
        {
            Feat feat = new Feat();
            feat.Name = "Stunning fist";
            feat.FType = "General";
            feat.Content = "You know how to strike opponents in vulnerable areas.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(RequiredStat(5, 13));
            feat.Prerequisite.Add(ImprovedUnarmedStrike());
            feat.Prerequisite.Add(RequiredBAB(8));
            feat.Benefit = "You must declare that you are using this feat before you make your attack roll (thus, a failed attack roll ruins the attempt). Stunning Fist forces a foe damaged by your unarmed attack to make a Fortitude saving throw (10 + 1/2 your character level + your Wisdom modifier), in addition to dealing damage normally. A defender who fails this saving throw is stunned for 1 round (until just before your next action). A stunned character can't act, loses any Dexterity bonus to AC, and takes a -2 penalty to AC. You may attempt a stunning attack once per day for every four levels you have attained (but see Special), and no more than once per round. Constructs, oozes, plants, undead and incorperal creatures and creatures immune to critical hits cannot be stunned.";
            feat.Special = "A monk may select " + feat.Name + " as a bonus feat at 1st level, even if she does not meet the prerequisites. A monk who selects this feat may attempt a stunning attack a number of times per day equal to her monk level, plus one more time per day for every four levels she has in classes other monk.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Monk");
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        #endregion
        #region T
        public Feat Toughness()
        {
            Feat feat = new Feat();
            feat.Name = "Toughness";
            feat.FType = "General";
            feat.Content = "You are tougher than normal.";
            feat.Benefit = "You gain +3 hit points.";
            feat.Special = "A character may gain this feat multiple times. Its effects stack.";
            feat.Multiple = true;
            return feat;
        }
        public Feat TowerShieldProficiency()
        {
            Feat feat = new Feat();
            feat.Name = "Tower Shield Proficiency";
            feat.FType = "General";
            feat.Content = "You are proficient with tower shields.";
            feat.Benefit = "You can use a tower shield and suffer only the standard penalties.";
            feat.NormalWithout = "A character who is using a shield with which he or she is not proficient takes the shield's armor check penalty on attack rolls and on all skill checks that involve moving, including Ride.";
            feat.Special = "Fighters automatically have " + feat.Name + " as a bonus feat. They need not select it.";
            return feat;
        }
        public Feat Track()
        {
            Feat feat = new Feat();
            feat.Name = "Track";
            feat.FType = "General";
            feat.Content = "You can follow the trails of creatures and characters across most types of terrain.";
            //TODO List table
            feat.Benefit = "To find tracks or to follow them for 1 mile requires a successful Survival check. You must make another Survival check every time the tracks become difficult to follow, such as when other tracks cross them or when the tracks backtrack and diverge.\r\nYou move at half your normal speed (or at normal speed with a -5 penalty on the check or at up to twice your normal speed with a -20 penalty on the check). The DC depends on the surface and the prevailing conditions, as given on the table page 101 Players Handbook 3.5.\r\n";
            return feat;
        }
        public Feat Trample()
        {
            Feat feat = new Feat();
            feat.Name = "Trample";
            feat.FType = "General";
            feat.Content = "You are trained in using your mount to knock down opponents.";
            feat.Prerequisite.Add(RequiredSkill("Ride", 1));
            feat.Prerequisite.Add(MountedCombat());
            feat.Benefit = "When you attempt to overrun an opponent while mounted, your target may not choose to avoid you. Your mount may make one hoof attack against any target you knock down, gaining the standard +4 bonus on attack rolls against prone targets.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat TwoWeaponDefense()
        {
            Feat feat = new Feat();
            feat.Name = "Two-Weapon Defense";
            feat.FType = "General";
            feat.Content = "Your two-weapon fighting style bolsters your defense as well as your offense.";
            feat.Benefit = "When wielding a double weapon or two weapons (not including natural weapons or unarmed strikes), you gain a +1 shield bonus to your AC.\r\nWhen you are fighting defensively or using the total defense action, this shield bonus increases to +2.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat TwoWeaponFighting()
        {
            Feat feat = new Feat();
            feat.Name = "Two-Weapon Fighting";
            feat.FType = "General";
            feat.Content = "You can fight with a weapon in each hand. You can make one extra attack each round with the second weapon.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Benefit = "Your penalties on attack rolls for fighting with two weapons are reduced. The penalty for your primary hand lessens by 2 and the on for your off hand lessens by 6.";
            feat.NormalWithout = "";
            feat.Special = "A 2nd level ranger who has chosen the two weapon combat style is trated as having " + feat.Name + ", even if he does not have the prerequisite for it, but only when he is wearing light or no armor.\r\nA fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        #endregion
        #region W
        public Feat WeaponFinesse()
        {
            Feat feat = new Feat();
            feat.Name = "Weapon Finesse";
            feat.FType = "General";
            feat.Content = "You are especially skilled at using weapons that can benefit as much from Dexterity as from Strength.";
            feat.Prerequisite.Add(RequiredBAB(1));
            feat.Benefit = "With a light weapon, rapier, whip or spiked chain made for creature of your size category, you may use your Dexterity modifier instead of your Strength modifier. If you carry a shield, its armor check penalty applies to your attack rolls.";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.\r\nNatural weapons are always considered light weapons.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat WeaponFocus(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Weapon focus(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose one type of weapon, such as greataxe. You can also choose unarmed strike or grapple (or ray, if you are a spellcaster) as your weapon for purposes of this feat. You are especially good at using this weapon. (If you have chosen ray, you are especially good with rays, such as the one produced by the ray of frost spell.)";
            feat.Prerequisite.Add("Proficiency with selected weapon");
            feat.Prerequisite.Add(RequiredBAB(1));
            feat.Benefit = "You gain a +1 bonus on all attack rolls you make using the selected weapon.";
            feat.Special = "You can gain this feat multiple times. Its effets do not stack. Each time you take the feat, it applies to a new type of weapon.\r\nA fighter may select Weapon Focus as one of his fighter bonus feats. He must have Weapon Focus with a weapon to gain the Weapon Specialization feat for that weapon.";
            feat.ClassBonus.Add("Fighter");
            feat.Multiple = true;
            return feat;
        }
        public Feat WeaponSpecialization(string _prop)
        {
            Feat feat = new Feat();
            feat.Property = _prop;
            feat.Name = "Weapon Specialization(" + _prop + ")";
            feat.FType = "General";
            feat.Content = "Choose one type of weapon, such as greataxe, for which you have already selected the Weapon Focus feat. You can also choose unarmed strike or grapple as your weapon for purposes of this feat. You deal extra damage when using this weapon.";
            feat.Prerequisite.Add("Proficiency with selected weapon");
            feat.Prerequisite.Add(WeaponFocus(_prop));
            feat.Prerequisite.Add("Fighter level 4th");
            feat.Benefit = "You gain a +2 bonus on all damage rolls you make using the selected weapon.";
            feat.Special = "You can gain this feat multiple times. Its effects do not stack. Each time you take the feat, it applies to a new type of weapon.\r\nA fighter may select Weapon Specialization as on of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            feat.Multiple = true;
            return feat;
        }
        public Feat WhirlwindAttack()
        {
            Feat feat = new Feat();
            feat.Name = "Whirlwind Attack";
            feat.FType = "General";
            feat.Content = "You can strike nearby opponents in an amazing, spinning attack.";
            feat.Prerequisite.Add(RequiredStat(2, 13));
            feat.Prerequisite.Add(RequiredStat(4, 13));
            feat.Prerequisite.Add(CombatExpertise());
            feat.Prerequisite.Add(Dodge());
            feat.Prerequisite.Add(Mobility());
            feat.Prerequisite.Add(SpringAttack());
            feat.Prerequisite.Add(RequiredBAB(4));
            feat.Benefit = "When you use the full attack action, you can give up your regular attacks and instead make one melee attack at your full base attack bonus against each opponent withing reach.\r\nWhen you use " + feat.Name + " feat, you also forfeit any bonus or extra attacks granted by other feats, spells or abilities (such as the Cleave feat or the haste spell).";
            feat.Special = "A fighter may select " + feat.Name + " as one of his fighter bonus feats.";
            feat.ClassBonus.Add("Fighter");
            return feat;
        }
        public Feat WidenSpell()
        {
            Feat feat = new Feat();
            feat.Name = "Widen Spell";
            feat.FType = "Metamagic";
            feat.Content = "You can increase the area of your spells.";
            feat.Benefit = "You can alter a burst, emanation, line or spread shaped spell to increase its area. Any numberic measurements of the spell's area increase by 100%. For example, a fireball spell (which normally produces a 20-foot-radius spread) that is widened now fills a 40-foot-radius spread. A widened spell uses up a spell slot three levels higher than the spell's actual level.\r\nSpells that do not have an area of one of these four sorts are not affect this feat.";
            return feat;
        }
        #endregion

        //public Feat Template()
        //{
        //    Feat feat = new Feat();
        //    feat.Name = "";
        //    feat.FType = "";
        //    feat.Content = "";
        //    feat.Benefit = "";
        //    return feat;
        //}

    }
}
