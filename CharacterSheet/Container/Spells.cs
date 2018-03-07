using CharacterSheet.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Container
{
    public class Spells
    {
        private static string _blank = "";
        #region Casters
        private static string brd = "Bard";
        private static string clr = "Cleric";
        private static string drd = "Druid";
        private static string pal = "Paladin";
        private static string rgr = "Ranger";
        private static string sor = "Sorcerer";
        private static string wiz = "Wizard";
        private static string air = "Air";
        private static string ani = "Animal";
        private static string cha = "Chaos";
        private static string dea = "Death";
        private static string des = "Destruction";
        private static string ear = "Earth";
        private static string evi = "Evil";
        private static string fir = "Fire";
        private static string goo = "Good";
        private static string hea = "Healing";
        private static string kno = "Knowledge";
        private static string law = "Law";
        private static string luc = "Luck";
        private static string mag = "Magic";
        private static string pla = "Plant";
        private static string pro = "Protection";
        private static string str = "Strength";
        private static string sun = "Sun";
        private static string tra = "Travel";
        private static string tri = "Trickery";
        private static string war = "War";
        private static string wat = "Water";
        #endregion

        #region Components
        private static string _v = "Verbal";
        private static string _s = "Somatic";
        private static string _m = "Material";
        private static string _f = "Focus";
        private static string _d = "Divine Focus";
        private static string _x = "XP cost";
        #endregion

        #region Schools
        private static string _abj = "Abjuration";
        private static string _con = "Conjuration";
        private static string _div = "Divination";
        private static string _enc = "Ecnhantment";
        private static string _evo = "Evocation";
        private static string _ill = "Illusion";
        private static string _nec = "Necromancy";
        private static string _tra = "Transmutation";
        private static string _uni = "Universal";
        #endregion

        #region Subschool
        private static string _cal = "Calling";
        private static string _cre = "Creation";
        private static string _hea = "Healing";
        private static string _sum = "Summoning";
        private static string _tel = "Teleportation";
        private static string _scr = "Scrying";
        private static string _cha = "Charm";
        private static string _com = "Compulsion";
        private static string _fig = "Figment";
        private static string _gla = "Glamer";
        private static string _pat = "Pattern";
        private static string _pha = "Phantasm";
        private static string _sha = "Shadow";
        #endregion

        #region Range
        private string CloseRange(int _cl)
        {
            decimal cal = _cl / 2;
            int res = 25 + (5 * Convert.ToInt32((Math.Floor(cal))));
            return "Close: " + res + "ft";
        }
        private string MediumRange(int _cl)
        {
            int res = 100 + (10 * _cl);
            return "Medium: " + res + "ft";
        }
        private string LongRange(int _cl)
        {
            int res = 400 + (_cl * 40);
            return "Long: " + res + "ft";
        }
        private static string _per = "Personal";
        private static string _tou = "Touch";
        private static string _unl = "Unlimited";
        #endregion

        #region Descriptor
        private static string _acid = "Acid";
        private static string _air = "Air";
        private static string _chaotic = "Chaotic";
        private static string _cold = "Cold";
        private static string _darkness = "Darkness";
        private static string _death = "Death";
        private static string _earth = "Earth";
        private static string _electricity = "Electricity";
        private static string _evil = "Evil";
        private static string _fear = "Fear";
        private static string _fire = "Fire";
        private static string _force = "Force";
        private static string _good = "Good";
        private static string _language = "Language-dependent";
        private static string _lawful = "Lawful";
        private static string _light = "Light";
        private static string _mindaff = "Mind-affecting";
        private static string _sonic = "Sonic";
        private static string _water = "Water";
        #endregion

        #region Target Effect Area
        private static string _target = "Target: ";
        private static string _effect = "Effect: ";
        private static string _area = "Area: ";
        #endregion

        #region Duration
        private static string _rounds = "1";
        private static string _minute = "2";
        private static string _hours = "3";
        private static string _instant = "Instantaneous";
        private static string _concent = "Concentration";
        private static string _permanent = "Permanent";
        #endregion

        #region Casting Time
        private static string _1a = "1 standard action";
        private static string _1sw = "1 swift action";
        #endregion

        #region Saving Throw
        private static string _willneg = "Will negates";
        private static string _willpart = "Will partial";
        private static string _refhalf = "Reflex halves";
        private static string _fortneg = "Fortitude negates";
        #endregion
        
        private int MaxCal(int _pr, int _max, int _cl)
        {
            int res = 0;


            if (_max > 0)
            {
                decimal cal = _cl / _pr;
                res = Convert.ToInt32(Math.Floor(cal));
                if (_max < cal)
                {
                    res = _max;
                }
            }
            else
            {
                decimal cal = _cl / _pr;
                res = Convert.ToInt32(Math.Floor(cal));
            }

            return res;
        }
        private string DurationTime(int _cl, string _dura, int _pr)
        {
            int res = 0;
            res = _cl * _pr;
            return res + " " + _dura + AddS(res);
        }
        private string AddS(int x)
        {
            string res = "";
            if (x > 1)
                res = "s";
            return res;
        }

        public List<Spell> AllSpells(int _cl)
        {
            List<Spell> listedSpells = new List<Spell>();
            #region A
            listedSpells.Add(AcidFog(_cl));
            listedSpells.Add(AcidSplash(_cl));
            listedSpells.Add(Aid(_cl));
            listedSpells.Add(AirWalk(_cl));
            listedSpells.Add(Alarm(_cl));
            listedSpells.Add(AlignWeapon(_cl));
            listedSpells.Add(AlterSelf(_cl));
            listedSpells.Add(AnalyzeDweomer(_cl));
            listedSpells.Add(AnimalGrowth(_cl));
            listedSpells.Add(AnimalMessenger(_cl));
            listedSpells.Add(AnimalShapes(_cl));
            listedSpells.Add(AnimalTrance(_cl));
            listedSpells.Add(AnimateDead(_cl));
            listedSpells.Add(AnimateObjects(_cl));
            listedSpells.Add(AnimatePlants(_cl));
            listedSpells.Add(AnimateRope(_cl));
            listedSpells.Add(AntilifeShell(_cl));
            listedSpells.Add(AntimagicField(_cl));
            listedSpells.Add(Antipathy(_cl));
            listedSpells.Add(AntiplantShell(_cl));
            listedSpells.Add(ArcaneEye(_cl));
            listedSpells.Add(ArcaneLock(_cl));
            listedSpells.Add(ArcaneMark(_cl));
            listedSpells.Add(ArcaneSight(_cl));
            listedSpells.Add(ArcaneSightGreater(_cl));
            listedSpells.Add(AstralProjection(_cl));
            listedSpells.Add(Atonement(_cl));
            listedSpells.Add(Augury(_cl));
            listedSpells.Add(Awaken(_cl));
            #endregion
            //listedSpells.Add((_cl));
            return listedSpells;
        } 

        public Spells() { }

        #region A
        public Spell AcidFog(int _cl)
        {
            Spell spell = new Spell();
            spell.Name = "Acid Fog";
            spell.School.Add(_con); ;
            spell.Subschool.Add(_cre);
            spell.Descriptor.Add(_acid);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(6, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(6, wiz));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(7, wat));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Arcane Material Component: A pinch of dried, powdered peas combined with powdered animal hoof");
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _effect + "Fog spreads in 20-ft radius, 20-ft high";
            spell.Duration = "1?"+_rounds;
            spell.SavingThrow = "None";
            spell.ShortDescription = "Fog deals acid damage.";
            spell.Description = "Acid fog creates a billowing mass of misty vapors similar to that produced by a solid fog spell (See Solid Fog spell). In addition to slowing creatures down and obscuring sight, this spell’s vapors are highly acidic. Each round on your turn, starting when you cast the spell, the fog deals 2d6 points of acid damage to each creature and object within it.";
            return spell;
        }
        public Spell AcidSplash(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Acid Splash";
            spell.School.Add(_con);
            spell.Subschool.Add(_cre);
            spell.Descriptor.Add(_acid);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(0, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(0, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _effect + "One missile of acid";
            spell.Duration = _instant;
            spell.SavingThrow = "None";
            spell.ShortDescription = "Orb deals 1d3 acid damage.";
            spell.Description = "You fire a small orb of acid at the target. You must succeed on a ranged touch attack to hit your target. The orb deals 1d3 points of acid damage.";

            return spell;
        }
        public Spell Aid(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Aid";
            spell.School.Add(_enc);
            spell.Subschool.Add(_com);
            spell.Descriptor.Add(_mindaff);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(2, goo));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(2, luc));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "Living creature touched";
            spell.Duration = DurationTime(_cl, _minute, 1);
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "+1 on attack rolls and saves against fear, 1d8 temporary hp +" + MaxCal(1,10,_cl) + " (max +10).";
            spell.Description = "Aid grants the target a +1 morale bonus on attack rolls and saves against fear effects, plus temporary hit points equal to 1d8 + "+MaxCal(1,10,_cl)+" (to a maximum of 1d8+10 temporary hit points at caster level 10th).";
            spell.isHarmless = true;

            return spell;
        }
        public Spell AirWalk(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Air Walk";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_air);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(4, air));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(4, clr));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(4, drd));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "Creature (Gargantuan or smaller) touched";
            spell.Duration = DurationTime(_cl, _minute, 10);
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.isHarmless = true;
            spell.ShortDescription = "Subject treads on air as if solid (climb at 45-degree angle).";
            spell.Description = "The subject can tread on air as if walking on solid ground. Moving upward is similar to walking up a hill. The maximum upward or downward angle possible is 45 degrees, at a rate equal to one-half the air walker’s normal speed.\r\nA strong wind (21+ mph) can push the subject along or hold it back. At the end of its turn each round, the wind blows the air walker 5 feet for each 5 miles per hour of wind speed. The creature can, at the DM’s option, be subject to additional penalties in exceptionally strong or turbulent winds, such as loss of control over movement or physical damage from being buffeted about.\r\nShould the spell duration expire while the subject is still aloft, the magic fails slowly. The subject floats downward 60 feet per round for 1d6 rounds. If it reaches the ground in that amount of time, it lands safely. If not, it falls the rest of the distance, taking 1d6 points of damage per 10 feet of fall. Since dispelling a spell effecttivelyends it, the subject also descends in this way if the air walk spell is dispelled, but not if it is negated by an antimagic field.\r\nYou can cast air walk on a specially trained mount so it can be ridden through the air. You can train a mount to move with the aid of air walk (counts as a trick; see page 74) with one week of work and a DC 25 Handle Animal check.";
            return spell;
        }
        public Spell Alarm(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Alarm";
            spell.School.Add(_abj);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(1, brd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(1, rgr));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(1, sor));
            spell.LevelAndClass.Insert(3, new KeyValuePair<int, string>(1, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_f + ": Arcane Focus: A tiny bell and a piece of very fine silver wire");
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _area + "20ft-radius emanation centered on a point in space";
            spell.Duration = DurationTime(_cl, _hours, 2) + " (D)";
            spell.SavingThrow = "None";
            spell.ShortDescription = "Wards an area for " + DurationTime(_cl, _hours, 2);
            spell.Description = "Alarm sounds a mental or audible alarm each time a creature of Tiny or larger size enters the warded area or touches it. A creature that speaks the password (determined by you at the time of casting) does not set off the alarm. You decide at the time of casting whether the alarm will be mental or audible.\r\nMental Alarm: A mental alarm alerts you (and only you) so long as you remain within 1 mile of the warded area. You note a single mental “ping” that awakens you from normal sleep but does not otherwise disturb concentration. A silence spell has no effect on a mental alarm.\r\nAudible Alarm: An audible alarm produces the sound of a hand bell, and anyone within 60 feet of the warded area can hear it clearly. Reduce the distance by 10 feet for each interposing closed door and by 20 feet for each substantial interposing wall. In quiet conditions, the ringing can be heard faintly as far as 180 feet away. The sound lasts for 1 round. Creatures within a silence spell cannot hear the ringing.\r\nEthereal or astral creatures do not trigger the alarm.\r\nAlarm can be made permanent with a permanency spell.";

            return spell;
        }
        public Spell AlignWeapon(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Align Weapon";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add("See text");
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, clr));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "Weapon touched or fifty projectiles (All of which must be in contact with each other at the time of casting)";
            spell.Duration = DurationTime(_cl, _minute, 1);
            spell.SavingThrow = _willneg;
            spell.isHarmless = true;
            spell.SpellResistance = true;
            spell.onlyObject = true;
            spell.ShortDescription = "Weapon becomes good, evil, lawful, or chaotic.";
            spell.Description = "Align weapon makes a weapon good, evil, lawful, or chaotic, as you choose. A weapon that is aligned can bypass the damage reduction of certain creatures, usually outsiders of the opposite alignment. This spell has no effect on a weapon that already has an alignment, such as a holy sword.\r\nYou can't cast this spell on a natural weapon, such as unarmed strike.\r\nWhen you make a weapon good, evil, lawful, or chaotic, align weapon is a good, evil, lawful, or chaotic spell, respectively.";

            return spell;
        }
        public Spell AlterSelf(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Alter Self";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, brd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(2, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(2, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = _per;
            spell.TarEffAer = _target + "You";
            spell.Duration = DurationTime(_cl, _minute, 10) + " (D)";
            spell.SavingThrow = "None";
            spell.ShortDescription = "assume form of a similar creature.";
            spell.Description = "You assume the form of a creature of the same type as your normal form (such as humanoid or magical beast). The new form must be within one size category of your normal size. The maximum HD of an assumed form is equal to your caster level, to a maximum of 5 HD at 5th level. You can change into a member of your own kind or even into yourself.\r\nYou retain your own ability scores. Your class and level, hit points, alignment, base attack bonus, and base save bonuses all remain the same. You retain all supernatural and spell-like special attacks and qualities of your normal form, except for those requiring a body part that the new form does not have (such as a mouth for a breath weapon or eyes for a gaze attack). You keep all extraordinary special attacks and qualities derived from class levels (such as a barbarian’s rage ability), but you lose any from your normal form that are not derived from class levels (such as a dragon’s frightful presence ability).\r\nIf the new form is capable of speech, you can communicate normally. You retain any spellcasting ability you had in your original form, but the new form must be able to speak intelligibly (that is, speak a language) to use verbal components and must have limbs capable of fine manipulation to use somatic or material components.\r\nYou acquire the physical qualities of the new form while retaining your own mind.Physical qualities include natural size, mundane movement capabilities(such as burrowing, climbing, walking, swimming, and flight with wings, to a maximum speed of 120 feet for flying or 60 feet for nonflying movement), natural armor bonus, natural weapons (such as claws, bite, and so on), racial skill bonuses, racial bonus feats, and any gross physical qualities(presence or absence of wings, number of extremities, and so forth).A body with extra limbs does not allow you to make more attacks (or more advantageous two - weapon attacks) than normal.\r\nYou do not gain any extraordinary special attacks or special qualities not noted above under physical qualities, such as darkvision, low - light vision, blindsense, blindsight, fast healing, regeneration, scent, and so forth.\r\nYou do not gain any supernatural special attacks, special qualities, or spell - like abilities of the new form.Your creature type and subtype (if any) remain the same regardless of your new form.You cannot take the form of any creature with a template, even if that template doesn’t change the creature type or subtype.\r\nYou can freely designate the new form’s minor physical qualities (such as hair color, hair texture, and skin color) within the normal ranges for a creature of that kind.The new form’s significant physical qualities(such as height, weight, and gender) are also under your control, but they must fall within the norms for the new form’s kind.You are effectively disguised as an average member of the new form’s race.If you use this spell to create a disguise, you get a + 10 bonus on your Disguise check.\r\nWhen the change occurs, your equipment, if any, either remains worn or held by the new form(if it is capable of wearing or holding the item), or melds into the new form and becomes nonfunctional.When you revert to your true form, any objects previously melded into the new form reappear in the same location on your body they previously occupied and are once again functional. Any new items you wore in the assumed form and can’t wear in your normal form fall off and land at your feet; any that you could wear in either form or carry in a body part common to both forms(mouth, hands, or the like) at the time of reversion are still held in the same way.Any part of the body or piece of equipment that is separated from the whole reverts to its true form.";

            return spell;
        }
        public Spell AnalyzeDweomer(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Analyze Dweomer";
            spell.School.Add(_div);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(6, brd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(6, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(6, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_f + ": Focus: A tiny lens of ruby or sapphire set in a small golden loop. The gemstone must be worth at least 1500 gp.");
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + _cl + " object"+AddS(_cl)+" or creature"+AddS(_cl);
            spell.Duration = DurationTime(_cl, _rounds, 1) + " (D)";
            spell.SavingThrow = "None or " +_willneg;
            spell.ShortDescription = "Reveals magical aspects of subject.";
            spell.Description = "You discern all spells and magical properties present in a number of creatures or objects. Each round, you may examine a single creature or object that you can see as a free action. In the case of a magic item, you learn its functions, how to activate its functions (if appropriate), and how many charges are left (if it uses charges). in the case of an object or creature with active spells cast upon it, you learn each spell, its effect, and its caster level.\r\nAn attended object may attempt a Will save to resist this effect if its holder so desires. If the save succeeds, you learn nothing about the object except what you can discern by looking at it. An object that makes its save cannot be affected by any other analyze dweomer spells for 24 hours.\r\nAnalyze dweomer does not function when used on an artifact (see the Dungeon Master’s Guide for details on artifacts).";

            return spell;
        }
        public Spell AnimalGrowth(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animal Growth";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(5, drd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(4, rgr));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(5, sor));
            spell.LevelAndClass.Insert(3, new KeyValuePair<int, string>(5, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _target + MaxCal(2, 0, _cl) + " animal"+AddS(_cl)+" (Gargantuan or smaller), no two of which can be more than 30ft. apart";
            spell.Duration = DurationTime(_cl, _minute, 1);
            spell.SavingThrow = _fortneg;
            spell.SpellResistance = true;
            spell.ShortDescription = MaxCal(2, 0, _cl) + " animal" + AddS(_cl) + " doubles in size.";
            spell.Description = "A number of animals grow to twice their normal size and eight times their normal weight. This alteration changes each animal’s size category to the next largest (from Large to Huge, for example), grants it a +8 size bonus to Strength and a +4 sizebonus to Constitution (and thus an extra 2 hit points per HD), and imposes a –2 size penalty to Dexterity. The creature’s existing natural armor bonus increases by 2. The size change also affects the animal’s modifier to AC and attack rolls and its base damage, as detailed on Table 2–2 in the Dungeon Master’s Guide. The animal’s space and reach change as indicated on Table 8– 4: Creature Size and Scale (page 149), but its speed does not change.\r\nThe spell also grants each subject damage reduction 10/magic and a +4 resistance bonus on saving throws.\r\nIf insufficient room is available for the desired growth, the creature attains the maximum possible size and may make aStrength check (using its increased Strength) to burst any enclosures in the process. If it fails, it is constrained without harm by the materials enclosing it—the spell cannot be used to crush a creature by increasing its size.\r\nAll equipment worn or carried by an animal is similarly enlarged by the spell, though this change has no effect on the magical properties of any such equipment. Any enlarged item that leaves the enlarged creature’s possession instantly returns to its normal size.\r\nThe spell gives no means of command or influence over the enlarged animals.\r\nMultiple magical effects that increase size do not stack, which means (among other things) that you can’t use a second casting of this spell to further increase the size of an animal that’s still under the effect of the first casting.";

            return spell;
        }
        public Spell AnimalMessenger(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animal Messenger";
            spell.School.Add(_enc);
            spell.Subschool.Add(_com);
            spell.Descriptor.Add(_mindaff);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, brd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(2, drd));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(1, rgr));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Material Component: A morsel of food the animal likes.");
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + "One Tiny animal";
            spell.Duration = DurationTime(_cl, "day", 1);
            spell.SavingThrow = "None; see text";
            spell.SpellResistance = true;
            spell.ShortDescription = "Sends a Tiny animal to a specific place.";
            spell.Description = "You compel a Tiny animal to go to a spot you designate. The most common use for this spell is to get an animal to carry a message to your allies. The animal cannot be one tamed or trained by someone else, including such creatures as familiars and animal companions.\r\n Using some type of food desirable to the animal as a lure, you call the animal to you. It advances and awaits your bidding. You can mentally impress on the animal a certain place well known to you or an obvious landmark (such as the peak of a distant mountain). The directions must be simple, because the animal depends on your knowledge and can’t find a destination on its own. You can attach some small item or note to the messenger. The animal then goes to the designated location and waits there until the duration of the spell expires, whereupon it resumes its normal activities.\r\n During this period of waiting, the messenger allows others to approach it and remove any scroll or token it carries. Unless the intended recipient of a message is expecting a messenger in the form of a bird or other small animal, the carrier may be ignored. The intended recipient gains no special ability to communicate with the animal or read any attached message (if it’s written in a language he or she doesn’t know, for example).";

            return spell;
        }
        public Spell AnimalShapes(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animal Shapes";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(7, ani));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(8, drd));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + MaxCal(1, 0, 1) + " willing creature"+AddS(_cl)+" all within 30 ft. of each other.";
            spell.Duration = DurationTime(_cl, _hours, 1) + " (D)";
            spell.SavingThrow = "None; see text";
            spell.isHarmless = true;
            spell.SpellResistance = true;
            spell.ShortDescription = MaxCal(1,0,_cl) + " allies polymorphs into chosen animal.";
            spell.Description = "As polymorph, except you polymorph up to one willing creature per caster level into an animal of your choice; the spell has no effect on unwilling creatures. All creatures must take the same animal form; for example, you can't turn one subjet into a hawk and another into a dire wolf. Recipients remain in the animal form until the spell expires or until you dismiss it for all recipients. In addition, an individual subject may choose to resume its normal form as a full-round action; doing so ends the spell for that subject alone. The maximum HD of assumed form is equal to the subject's HD or " + MaxCal(1, 20, _cl) + " to a maximum of 20 HD.";

            return spell;
        }
        public Spell AnimalTrance(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animal Trance";
            spell.School.Add(_enc);
            spell.Subschool.Add(_com);
            spell.Descriptor.Add(_mindaff);
            spell.Descriptor.Add(_sonic);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, brd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(2, drd));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + "Animals or magical beasts with Intelligence 1 or 2.";
            spell.Duration = _concent;
            spell.SavingThrow = _willneg + "; see text";
            spell.SpellResistance = true;
            spell.ShortDescription = "Fascinates 2d6 HD of animals.";
            spell.Description = "Your swaying motions and music (or singing, or chanting) compel animals and magical beasts to do nothing but watch you. Only a creature with an Intelligence score of 1 or 2 can be fascinated by this spell. Roll 2d6 ti determine the total number of HD worth of creatures that you fascinate. The closest targets are selected first until no more targets within range can be affected. For example, if Vadania affects 7 HD worth of animals and there are several 2 HD wolves within close range, only the three closest wolves are affected.\r\nA magical beast, a dire animal, or an animal trained to attack or guard is allowed a saving throw; an animal not trained to attack or guard is not.";

            return spell;
        }
        public Spell AnimateDead(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animate Dead";
            spell.School.Add(_nec);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_evil);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(3, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(3, dea));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(4, sor));
            spell.LevelAndClass.Insert(3, new KeyValuePair<int, string>(4, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Material Component: You must place a black onyx gem worth at least 25 pg pr Hit Die of the undead into the mouth or eye socket of each corpse you intend to animate. The magic of the spell turns these gems into worthless burned-out shells.");
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "One or more corpses touched.";
            spell.Duration = _instant;
            spell.SavingThrow = "None";
            spell.ShortDescription = "Creates undead skeletons and zombies.";
            spell.Description = "This spell turns the bones or bodies of dead creatures into undead skeletons or zombies that follow your spoken commands. The undead can follow you, or they can remain in an area and attack any creature (or just a specific kind of creature) entering the place. They remain animated until they are destroyed. (A destroyed skeleton or zombie can’t be animated again.)\r\nRegardless of the type of undead you create with this spell, you can’t create more HD of undead than twice your caster level with a single casting of animate dead. (The desecrate spell doubles this limit; see page 218.)\r\nThe undead you create remain under your control indefinitely. No matter how many times you use this spell, however, you can control only 4 HD worth of undead creatures per caster level. If you exceed this number, all the newly created creatures fall under your control, and any excess undead from previous castings become uncontrolled. (You choose which creatures are released.) If you are a cleric, any undead you might command by virtue of your power to command or rebuke undead do not count toward the limit.\r\nSkeletons: A skeleton can be created only from a mostly intact corpse or skeleton. The corpse must have bones, so creating a skeleton from a purple worm, for example, is not possible. If a skeleton is made from a corpse, the flesh falls off the bones. The statistics for a skeleton depend on its size; they do not depend on what abilities the creature may have had while alive. The Monster Manual has game statistics for skeletons.\r\nZombies: A zombie can be created only from a mostly intact corpse. The corpse must be that of a creature with a true anatomy, so a dead gelatinous cube, for example, cannot be animated as a zombie. The statistics for a zombie depend on its size, not on what abilities the creature may have had while alive. The Monster Manual has game statistics for zombies.";

            return spell;
        }
        public Spell AnimateObjects(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animate Objects";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(6, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(6, brd));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(6, cha));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _target + MaxCal(1, 0, _cl) + " Small object" + AddS(_cl) + "; see text." ;
            spell.Duration = DurationTime(_cl, _rounds, 1);
            spell.SavingThrow = "None";
            spell.ShortDescription = "Objects attack your foes.";
            spell.Description = "You imbue inanimate objects with mobility and a semblance of life. Each such animated object then immediately attacks whomever or whatever you initially designate. An animated object can be of any nonmagical material—wood, metal, stone, fabric, leather, ceramic, glass, or the like.. You may animate one Small or smaller object (such as a chair) or an equivalent number of larger objects per caster level. A Medium object (such as a coat rack) counts as two Small or smaller objects, a Large object (such as a table) as four, a Huge object as eight, a Gargantuan object as sixteen, and a Colossal object as thirty-two. You can change the designated target or targets as a move action, as if directing an active spell.\r\n The Monster Manual has game statistics for animated objects.\r\n This spell cannot animate objects carried or worn by a creature.\r\n Animate objects can be made permanent with a permanency spell.";

            return spell;
        }   
        public Spell AnimatePlants(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animate Plants";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(7, drd));
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(7, pla));
            spell.Components.Add(_v);
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + MaxCal(3, 0, _cl) + " Large plant" + AddS(MaxCal(3, 0, _cl)) + " or all plants withing range; see text";
            spell.Duration = DurationTime(_cl, _rounds, 1) + "or" + DurationTime(_cl, _hours, 1) + "; see text.";
            spell.SavingThrow = "None";
            spell.ShortDescription = "One or more trees animate and fight for you.";
            spell.Description = "You imbue inanimate plants with mobility and a semblance of life. Each animated plant then immediately attacks whomever or whatever you initially designate as though it were an animated object of the appropriate size category. You may animate one Large or smaller plant (such as a tree), or an equivalent number of larger plants, per three caster levels. A Huge plant counts as two Large or smaller plants, a Gargantuan plant as four, and a Colossal plant as eight. You can change the designated target or targets as a move action, as if directing an active spell.\r\nUse the statistics for animated objects found in the Monster Manual, except that plants smaller than Large don’t have hardness unless the DM rules otherwise for a given case.\r\nAnimate plants cannot affect plant creatures (such as treants), nor does it affect nonliving vegetable material (such as a cotton tunic or hempen rope).\r\nEntangle: Alternatively, you may imbue all plants within range with a degree of mobility, which allows them to entwine around creatures in the area. This usage of the spell duplicates the effect of an entangle spell. Spell resistance does not keep creatures from being entangled. This effect lasts 1 hour per caster level.";

            return spell;
        }
        public Spell AnimateRope(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Animate Rope";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(1, brd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(1, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(1, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _target + "One ropelike object, length up to "+Convert.ToInt32(50+MaxCal(5,0,1))+"ft; see text.";
            spell.Duration = DurationTime(_cl, _rounds, 1);
            spell.SavingThrow = "None";
            spell.ShortDescription = "Make a rope move at your command.";
            spell.Description = "You can animate a nonliving ropelike object, such as string, yarn, cord, line, rope, or even a cable. The maximum length assumes a rope with a 1-inch diameter. Reduce the maximum length by 50% for every additional inch of thickness, and increase it by 50% for each reduction of the rope’s diameter by half.\r\nThe possible commands are “coil” (form a neat, coiled stack), “coil and knot,” “loop,” “loop and knot,” “tie and knot,” and the opposites of all of the above (“uncoil,” and so forth). You can give one command each round as a move action, as if directing an active spell.\r\nThe rope can enwrap only a creature or an object within 1 foot of it—it does not snake outward—so it must be thrown near the intended target. Doing so requires a successful ranged touch attack roll (range increment 10 feet). A typical 1-inchdiameter hempen rope has 2 hit points, AC 10, and requires a DC 23 Strength check to burst it. The rope does not deal damage, but it can be used as a trip line or to cause a single opponent that fails a Reflex saving throw to become entangled. A creature capable of spellcasting that is bound by this spell must make a DC 15 Concentration check to cast a spell. An entangled creature can slip free with a DC 20 Escape Artist check.\r\nThe rope itself and any knots tied in it are not magical.\r\nThis spell grants a +2 bonus on any Use Rope checks you make when using the transmuted rope.\r\nThe spell cannot animate objects carried or worn by a creature.";

            return spell;
        }
        public Spell AntilifeShell(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Antilife Shell";
            spell.School.Add(_abj);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(6, ani));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(6, clr));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(6, drd));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = "1 round";
            spell.Range = "10ft";
            spell.TarEffAer = _area + "10ft-radius emanation, centered on you.";
            spell.Duration = DurationTime(_cl, _rounds, 10);
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "10-ft. field hedges out living creatures.";
            spell.Description = "You bring into being a mobile, hemispherical energy field that prevents the entrance of most types of living creatures. The effect hedges out animals, aberrations, dragons, fey, giants, humanoids, magical beasts, monstrous humanoids, oozes, plants, and vermin, but not constructs, elementals, outsiders, or undead. See the Monster Manual for more about creature types.\r\nThis spell may be used only defensively, not aggressively. Forcing an abjuration barrier against creatures that the spell keeps at bay collapses the barrier (see Abjuration, page 172).";

            return spell;
        }
        public Spell AntimagicField(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Antimagic Field";
            spell.School.Add(_abj);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(8, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(6, mag));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(6, pro));
            spell.LevelAndClass.Insert(3, new KeyValuePair<int, string>(6, sor));
            spell.LevelAndClass.Insert(4, new KeyValuePair<int, string>(6, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Arcane Material Component: A pinch of powdered iron or iron filings.");
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = "10ft";
            spell.TarEffAer = _area + "10ft-radius emanation centered on you.";
            spell.Duration = DurationTime(_cl, _minute, 10) + " (D)";
            spell.SavingThrow = "None";
            spell.ShortDescription = "Negates magic within 10 ft.";
            spell.Description = "An invisible barrier surrounds you and moves with you. The space within this barrier is impervious to most magical effects, including spells, spell-like abilities, and supernatural abilities. Likewise, it prevents the functioning of any magic items or spells within its confines.\r\nAn antimagic field suppresses any spell or magical effect used within, brought into, or cast into the area, but does not dispel it. A hasted creature, for example, is not hasted while inside the field, but the spell resumes functioning when the creature leaves the field. Time spent within an antimagic field counts against the suppressed spell’s duration.\r\nSummoned creatures of any type and incorporeal undead wink out if they enter an antimagic field. They reappear in the same spot once the field goes away. Time spent winked out counts normally against the duration of the conjuration that is maintaining the creature. If you cast antimagic field in an area occupied by a summoned creature that has spell resistance, you must make a caster level check (1d20 + caster level) against the creature’s spell resistance to make it wink out. (The effects of instantaneous conjurations, such as create water, are not affected by an antimagic field because the conjuration itself is no longer in effect, only its result.)\r\nA normal creature (a normally encountered griffon rather than a conjured one, for instance) can enter the area, as can normal missiles. Furthermore, while a magic sword does not function magically within the area, it is still a sword (and a masterwork sword at that). The spell has no effect on golems and other constructs that are imbued with magic during their creation process and are thereafter selfsupporting (unless they have been summoned, in which case they are treated like any other summoned creatures). Elementals, corporeal undead, and outsiders are likewise unaffected unless summoned. These creatures’ spell-like or supernatural abilities, however, may be temporarily nullified by the field.\r\nDispel magic does not remove the field. Two or more antimagic fields sharing any of the same space have no effect on each other. Certain spells, such as wall of force, prismatic sphere, and prismatic wall, remain unaffected by antimagic field (see the individual spell descriptions). Artifacts and deities are unaffected by mortal magic such as this. (See the Dungeon Master’s Guide for more about artifacts.)\r\nShould a creature be larger than the area enclosed by the barrier, any part of it that lies outside the barrier is unaffected by the field.";

            return spell;
        }
        public Spell Antipathy(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Antipathy";
            spell.School.Add(_enc);
            spell.Subschool.Add(_com);
            spell.Descriptor.Add(_mindaff);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(9, drd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(8, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(8, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Arcane Material Component: A lump of alum soaked in vinegar");
            spell.Components.Add(_d);
            spell.CastingTime = "1 hour";
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + "One location (up to "+ Convert.ToInt32(MaxCal(1, 0, _cl) * 10) +"ft cube) or one object";
            spell.Duration = DurationTime(_cl, _hours, 2);
            spell.SavingThrow = _willpart;
            spell.SpellResistance = true;
            spell.ShortDescription = "Object or location affected by spell repels certain creatures.";
            spell.Description = "You cause an object or location to emanate magical vibrations that repel either a specific kind of intelligent creature or creatures of a particular alignment, as defined by you. The kind of creature to be affected must be named specifically—for example, red dragons, hill giants, wererats, lammasus, cloakers, or vampires. A creature subtype (such as goblinoid) is not specific enough. Likewise, the specific alignment to be repelled must be named— for example, chaotic evil, chaotic good, lawful neutral, or neutral.\r\nCreatures of the designated kind or alignment feel an overpowering urge to leave the area or to avoid the affected item. A compulsion forces them to abandon the area or item, shunning it and never willingly returning to it while the spell is in effect. A creature that makes a successful saving throw can stay in the area or touch the item but feels uncomfortable doing so. This distracting discomfort reduces the creature’s Dexterity score by 4 points.\r\nAntipathy counters and dispels sympathy.";

            return spell;
        }
        public Spell AntiplantShell(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Antiplant Shell";
            spell.School.Add(_abj);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(4, drd));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = "10ft";
            spell.TarEffAer = _area + "10ft-radius emanation, centered on you";
            spell.Duration = DurationTime(_cl, _minute, 10);
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Keeps animated plants at bay.";
            spell.Description = "The antiplant shell spell creates an invisible, mobile barrier that keeps all creatures within the shell protected from attacks by plant creatures or animated plants. As with many abjuration spells, forcing the barrier against creatures that the spell keeps at bay strains and colapses the field (See Abjuration, page 172).";

            return spell;
        }
        public Spell ArcaneEye(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Arcane Eye";
            spell.School.Add(_div);
            spell.Subschool.Add(_scr);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(4, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(4, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + "A bit of bat fur");
            spell.CastingTime = "10 minutes";
            spell.Range = _unl;
            spell.TarEffAer = _effect + "Magical sensor";
            spell.Duration = DurationTime(_cl, _minute, 1);
            spell.SavingThrow = "None";
            spell.ShortDescription = "Invisible floating eye moves 30 ft./round.";
            spell.Description = "You create an invisible magical sensor that sends you visual information. You can create the arcane eye at any point you can see, but it can then travel outside your line of sight without hindrance. An arcane eye travels at 30 feet per round (300 feet per minute) if viewing an area ahead as a human would (primarily looking at the floor) or 10 feet per round (100 feet per minute) if examining the ceiling and walls as well as the floor ahead. It sees exactly as you would see if you were there. The eye can travel in any direction as long as the spell lasts. Solid barriers block its passage, but it can pass through a hole or space as small as 1 inch in diameter. The eye can’t enter another plane of existence, even through a gate or similar magical portal.\r\nYou must concentrate to use an arcane eye. If you do not concentrate, the eye is inert until you again concentrate.";

            return spell;
        }
        public Spell ArcaneLock(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Arcane Lock";
            spell.School.Add(_abj);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(2, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Material Component: Gold dust worth 25 gp");
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "The door, chest or portal touched, up to "+Convert.ToInt32(MaxCal(1,0,_cl) * 30)+"ft in size";
            spell.Duration = _permanent;
            spell.SavingThrow = "None";
            spell.ShortDescription = "Magically locks a portal or chest.";
            spell.Description = "An arcane lock spell cast upon a door, chest, or portal magically locks it. You can freely pass your own arcane lock without affecting it; otherwise, a door or object secured with this spell can be opened only by breaking in or with a successful dispel magic or knock spell. Add 10 to normal DC to break open a door or portal affected by this spell. (A knock spell does not remove arcane lock; it only supresses the effect for 10 minutes.)";

            return spell;
        }
        public Spell ArcaneMark(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Arcane Mark";
            spell.School.Add(_uni);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(0, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(0, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = "0ft";
            spell.TarEffAer = _effect + "One personal rune or mark, all of which must fit within 1 sq. ft.";
            spell.Duration = _permanent;
            spell.SavingThrow = "None";
            spell.ShortDescription = "Inscribes a personal rune (visible or invisible).";
            spell.Description = "This spell allows you to inscribe your personal rune or mark, which can consist of no more than six characters. The writing can be visible or invisible. An arcane mark spell enables you to etch the rune upon any substance (even stone or metal) without harm to the material upon which it is placed. If an invisible mark is made, a detect magic spell causes it to glow and be visible, though not necessarily understandable. See invisibility, true seeing, a gem of seeing, or a robe of eyes likewise allows the user to see an invisible arcane mark. A read magic spell reveals the words, if any. The mark cannot be dispelled, but it can be removed by the caster or by an erase spell. If an arcane mark is placed on a living being, normal wear gradually causes the effect to fade in about a month.\r\nArcane mark must be cast on an object prior to casting Drawmij’s instant summons on the same object (see that spell description for details).";

            return spell;
        }
        public Spell ArcaneSight(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Arcane Sight";
            spell.School.Add(_div);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(3, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(3, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = _per;
            spell.TarEffAer = _target + "You";
            spell.Duration = DurationTime(_cl, _minute, 1) + "(D)";
            spell.SavingThrow = "None";
            spell.ShortDescription = "Magical auras become visible to you.";
            spell.Description = "This spell makes your eyes glow blue and allows you to see magical auras within 120 feet of you. The effect is similar to that of a detect magic spell, but arcane sight does not require concentration and discerns aura location and power more quickly.\r\nYou know the location and power of all magical auras within your sight. An aura’s power depends on a spell’s functioning level or an item’s caster level, as noted in the description of the detect magic spell (page 219). If the items or creatures bearing the auras are in line of sight, you can make Spellcraft skill checks to determine the school of magic involved in each. (Make one check per aura; DC 15 + spell level, or 15 + one-half caster level for a nonspell effect.)\r\nIf you concentrate on a specific creature within 120 feet of you as a standard action, you can determine whether it has any spellcasting or spell-like abilities, whether these are arcane or divine (spell-like abilities register as arcane), and the strength of the most powerful spell or spelllike ability the creature currently has available for use. In some cases, arcane sight may give a deceptively low reading—for example, when you use it on a spellcaster who has used up most of his or her daily spell allotment.\r\nArcane sight can be made permanent with a permanency spell.";

            return spell;
        }
        public Spell ArcaneSightGreater(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Arcane Sight, Greater";
            spell.School.Add(_div);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(7, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(7, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = _per;
            spell.TarEffAer = _target + "You";
            spell.Duration = DurationTime(_cl, _minute, 1) + "(D)";
            spell.SavingThrow = "None";
            spell.ShortDescription = "As arcane sight, but also reveals magic effects on creatures and objects.";
            spell.Description = "This spell functions like arcane sight, except that you automatically know which spells or magical effects are active upon any individual or object you see.\r\nGreater arcane sight doesn’t let you identify magic items.\r\nUnlike arcane sight, this spell cannot be made permanent with a permanency spell.";

            return spell;
        }
        public Spell AstralProjection(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Astral Projection";
            spell.School.Add(_nec);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(9, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(9, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(9, wiz));
            spell.LevelAndClass.Insert(3, new KeyValuePair<int, string>(9, tra));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Material Component: A jacinth worth at least 1,000 gp, plus a silver bar worth 5 gp for each person to be affected.");
            spell.CastingTime = "30 minutes";
            spell.Range = _tou;
            spell.TarEffAer = _target + "You plus "+ MaxCal(2, 0, _cl) +" additaional willing creature"+AddS(MaxCal(2, 0, _cl))+ " touched";
            spell.Duration = "See text";
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Projects you and companions onto Astral Plane.";
            spell.Description = "By freeing your spirit from your physical body, this spell allows you to project an astral body onto another plane altogether. You can bring the astral forms of other willing creatures with you, provided that these subjects are linked in a circle with you at the time of the casting. These fellow travelers are dependent upon you and must accompany you at all times. If something happens to you during the journey, your companions are stranded wherever you left them.\r\nYou project your astral self onto the Astral Plane, leaving your physical body behind on the Material Plane in a state of suspended animation. The spell projects an astral copy of you and all you wear or carry onto the Astral Plane. Since the Astral Plane touches upon other planes, you can travel astrally to any of these other planes as you will. To enter one, you leave the Astral Plane, forming a new physical body (and equipment) on the plane of existence you have chosen to enter.\r\nWhile you are on the Astral Plane, your astral body is connected at all times to your physical body by a silvery cord. If the cord is broken, you are killed, astrally and physically. Luckily, very few things can destroy a silver cord (see the Dungeon Master’s Guide for more information). When a second body is formed on a different plane, the incorporeal silvery cord remains invisibly attached to the new body. If the second body or the astral form is slain, the cord simply returns to your body where it rests on the Material Plane, thereby reviving it from its state of suspended animation. Although astral projections are able to function on the Astral Plane, their actions affect only creatures existing on the Astral Plane; a physical body must be materialized on other planes.\r\nYou and your companions may travel through the Astral Plane indefinitely. Your bodies simply wait behind in a state of suspended animation until you choose to return your spirits to them. The spell lasts until you desire to end it, or until it is terminated by some outside means, such as dispel magic cast upon either the physical body or the astral form, the breaking of the silver cord, or the destruction of your body back on the Material Plane (which kills you).";

            return spell;
        }
        public Spell Atonement(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Atonement";
            spell.School.Add(_abj);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(5, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(5, drd));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Material Component: Burning incense");
            spell.Components.Add(_f + ": Focus: In addition to your holy symbol or normal divine focus, you need a set of prayer beads (or other prayer device, such as a prayer wheel or prayer book) worth at least 500 gp.");
            spell.Components.Add(_d);
            spell.Components.Add(_x + ": XP Cost: When cast for the benefit of a creature whose guilt was the result of deliberate acts, the cost to you is 500 xp per casting (see above).");
            spell.CastingTime = "1 hour";
            spell.Range = _tou;
            spell.TarEffAer = _target + "Living creature touched";
            spell.Duration = _instant;
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Removes burden of misdeeds from subject.";
            spell.Description = "This spell removes the burden of evil acts or misdeeds from the subject. The creature seeking atonement must be truly repentant and desirous of setting right its misdeeds. If the atoning creature committed the evil act unwittingly or under some form of compulsion, atonement operates normally at no cost to you. However, in the case of a creature atoning for deliberate misdeeds and acts of a knowing and willful nature, you must intercede with your deity (requiring you to expend 500 XP) in order to expunge the subject’s burden. Many casters first assign a subject of this sort a quest (see geas/quest) or similar penance to determine whether the creature is truly contrite before casting the atonement spell on its behalf.\r\nAtonement may be cast for one of several purposes, depending on the version selected.\r\nReverse Magical Alignment Change: If a creature has had its alignment magically changed, atonement returns its alignment to its original status at no cost in experience points.\r\nRestore Class: A paladin who has lost her class features due to committing an evil act may have her paladinhood restored to her by this spell.\r\nRestore Cleric or Druid Spell Powers: A cleric or druid who has lost the ability to cast spells by incurring the anger of his or her deity may regain that ability by seeking atonement from another cleric of the same deity or another druid. If the transgression was intentional, the casting cleric loses 500 XP for his intercession. If the transgression was unintentional, he does not lose XP.\r\nRedemption or Temptation: You may cast this spell upon a creature of an opposing alignment in order to offer it a chance to change its alignment to match yours. The prospective subject must be present for the entire casting process. Upon completion of the spell, the subject freely chooses whether it retains its original alignment or acquiesces to your offer and changes to your alignment. No duress, compulsion, or magical influence can force the subject to take advantage of the opportunity offered if it is unwilling to abandon its old alignment. This use of the spell does not work on outsiders or any creature incapable of changing its alignment naturally.\r\nThough the spell description refers to evil acts, atonement can also be used on any creature that has performed acts against its alignment, whether those acts are evil, good, chaotic, or lawful.\r\nNote: Normally, changing alignment is up to the player (for PCs) or the DM (for NPCs). This use of atonement simply offers a believable way for a character to change his or her alignment drastically, suddenly, and definitively.";

            return spell;
        }
        public Spell Augury(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Augury";
            spell.School.Add(_div);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, clr));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Material Component: Incense worth at least 25 gp.");
            spell.Components.Add(_f + ": Focus: A set of marked sticks, bones, or similiar tokens of at least 25 gp value.");
            spell.CastingTime = "1 minute";
            spell.Range = _per;
            spell.TarEffAer = _target + "You";
            spell.Duration = _instant;
            spell.SavingThrow = "None";
            spell.ShortDescription = "Learns whether an action will be good or bad.";
            spell.Description = "An augury can tell you whether a particular action will bring good or bad results for you in the immediate future. For example, if a character is considering destroying a weird seal that closes a portal, an augury might determine whether that act is a good idea.\r\nThe base chance for receiving a meaningful reply is "+Convert.ToInt32(70+MaxCal(1, 20,_cl))+"; the DM makes the roll secretly. The DM may determine that a question is so straightforward that a successful result is automatic, or so vague as to have no chance of success. If the augury succeeds, you get one of four results:\r\n\r\nWeal (if the action will probably bring good results).\r\nWoe (for bad results).\r\nWeal and woe (for both).\r\nNothing (for actions that don’t have especially good or bad results).\r\nIf the spell fails, you get the “nothing” result. A cleric who gets the “nothing” result has no way to tell whether it was the consequence of a failed or successful augury.\r\nThe augury can see into the future only about half an hour, so anything that might happen after that does not affect the result. Thus, the result might not take into account the long-term consequences of a contemplated action. All auguries cast by the same person about the same topic use the same dice result as the first casting.";

            return spell;
        }
        public Spell Awaken(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Awaken";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(5, drd));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.Components.Add(_x + ": XP Cost: 250 XP");
            spell.CastingTime = "24 Hours";
            spell.Range = _tou;
            spell.TarEffAer = _target + "Animal or tree touched";
            spell.Duration = _instant;
            spell.SavingThrow = _willneg;
            spell.SpellResistance = true;
            spell.ShortDescription = "Animal or tree gains human intellect.";
            spell.Description = "You awaken a tree or animal to humanlike sentience. To succeed, you must make a Will save (DC 10 + the animal’s current HD, or the HD the tree will have once awakened).\r\nThe awakened animal or tree is friendly toward you. You have no special empathy or connection with a creature you awaken, although it serves you in specific tasks or endeavors if you communicate your desires to it.\r\nAn awakened tree has characteristics as if it were an animated object (see the Monster Manual), except that it gains the plant type and its Intelligence, Wisdom, and Charisma scores are each 3d6. An awakened plant gains the ability to move its limbs, roots, vines, creepers, and so forth, and it has senses similar to a human’s.\r\nAn awakened animal gets 3d6 Intelligence, +1d3 Charisma, and +2 HD. Its type becomes magical beast (augmented animal). An awakened animal can’t serve as an animal companion, familiar, or special mount.\r\nAn awakened tree or animal can speak one language that you know, plus one additional language that you know per point of Intelligence bonus (if any).";

            return spell;
        }
        #endregion
        #region B
        public Spell BalefulPolymorph(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Baleful Polymorph";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(5, drd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(5, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(5, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + "One creature";
            spell.Duration = _permanent;
            spell.SavingThrow = _fortneg + ", "+_willpart;
            spell.SpellResistance = true;
            spell.ShortDescription = "Transforms subject into harmless animal.";
            spell.Description = "As polymorph, except that you change the subject into a Small or smaller animal of no more than 1 HD (such as a dog, lizard, monkey, or toad). If the new form would prove fatal to the creature (for example, if you polymorphed a landbound target into a fish, or a flying target into a toad) the subject gets a +4 bonus on the save.\r\nIf the spell succeeds, the subject must also make a Will save. If this second save fails, the creature loses its extraordinary, supernatural, and spell-like abilities, loses its ability to cast spells (if it had the ability), and gains the alignment, special abilities, and Intelligence, Wisdom, and Charisma scores of its new form in place of its own. It still retains its class and level (or HD), as well as all benefits deriving therefrom (such as base attack bonus, base save bonuses, and hit points). It retains any class features (other than spellcasting) that aren’t extraordinary, supernatural, or spelllike abilities.\r\nIncorporeal or gaseous creatures are immune to being polymorphed, and a creature with the shapechanger subtype (such as a lycanthrope or a doppelganger) can revert to its natural form as a standard action.";

            return spell;
        }
        public Spell Bane(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bane";
            spell.School.Add(_enc);
            spell.Subschool.Add(_com);
            spell.Descriptor.Add(_fear);
            spell.Descriptor.Add(_mindaff);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(1, clr));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = "50ft";
            spell.TarEffAer = _area + "All enemies within 50ft";
            spell.Duration = DurationTime(_cl, _minute, 1);
            spell.SavingThrow = _willneg;
            spell.SpellResistance = true;
            spell.ShortDescription = "Enemies take -1 on attack rolls and saves against fear.";
            spell.Description = "Bane fills your enemies with fear and doubt. Each affected creature takes a –1 penalty on attack rolls and a –1 penalty on saving throws against fear effects.\r\nBane counters and dispels bless.";

            return spell;
        }
        public Spell Banishment(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Banishment";
            spell.School.Add(_abj);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(6, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(7, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(7, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_f + ": Arcane Focus: Any item that is distasteful to the subject (optional, see text).");
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + "One or more extraplanar creatures, no two of which can be more than 30ft apart";
            spell.Duration = _instant;
            spell.SavingThrow = _willneg;
            spell.SpellResistance = true;
            spell.ShortDescription = "Banishes " + MaxCal(2, 0, _cl) + " HD of extraplanar creatures.";
            spell.Description = "A banishment spell is a more powerful version of the dismissal spell. It enables you to force extraplanar creatures out of your home plane. As many as "+Convert.ToInt32(2*MaxCal(1,0,_cl))+" Hit Dice can be banished. You can improve the spell’s chance of success by presenting at least one object or substance that the target hates, fears, or otherwise opposes. For each such object or substance, you gain a +1 bonus on your caster level check to overcome the target’s spell resistance (if any), the saving throw DC increases by 2. For example, if this spell were cast on a demon that hated light and was vulnerable to holy water and cold iron weapons, you might use iron, holy water, and a torch in the spell. The three items would give you a +3 bonus on your check to overcome the demon’s spell resistance and add 6 to the spell’s save DC.\r\nAt the DM’s option, certain rare items might work twice as well as a normal item for the purpose of the bonuses (each providing a +2 bonus on the caster level check against spell resistane and increasing thesave DC by 4).";

            return spell;
        }
        public Spell Barkskin(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Barkskin";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, drd));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(2, rgr));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(2, pla));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "Living creature touched";
            spell.Duration = DurationTime(_cl, _minute, 10);
            spell.SavingThrow = "None";
            spell.isHarmless = true;
            spell.SpellResistance = true;
            spell.ShortDescription = "Grants +2 (or higher) enhancement to natural armor.";
            spell.Description = "Barkskin toughens a creature’s skin. The effect grants a +"+ Convert.ToInt32(2 + MaxCal(3, 12, (_cl - 3))) +" enhancement bonus to the creature’s existing natural armor bonus to a maximum of +5 at caster level 12.\r\nThe enhancement bonus provided by barkskin stacks with the target’s natural armor bonus, but not with other enhancement bonuses to natural armor. A creature without natural armor has an effective natural armor bonus of +0, much as a character wearing only normal clothing has an armor bonus of +0.";

            return spell;
        }
        public Spell BearsEndurance(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bear's Endurance";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(2, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(2, drd));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(2, rgr));
            spell.LevelAndClass.Insert(3, new KeyValuePair<int, string>(2, sor));
            spell.LevelAndClass.Insert(4, new KeyValuePair<int, string>(2, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "Creature touched";
            spell.Duration = DurationTime(_cl, _minute, 1);
            spell.SavingThrow = _willneg;
            spell.isHarmless = true;
            spell.SpellResistance = true;
            spell.ShortDescription = "Subject gains +4 con for " + DurationTime(_cl, _minute, 1);
            spell.Description = "The affected creature gains greater vitality and stamina. The spell grants the subject a +4 enhancement bonus to Constitution, which adds the usual benefits to hit points, Fortitude saves, Constitution checks, and so forth.\r\nHit points gained by a temporary increase in Constitution score are not temporary hit points. They go away when the subject’s Constitution drops back to normal. They are not lost first as temporary hit points are (see page 146).";

            return spell;
        }
        public Spell BearsEnduranceMass(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bear's Endurance, Mass";
            spell.School.Add(_tra);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(6, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(6, drd));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(6, sor));
            spell.LevelAndClass.Insert(3, new KeyValuePair<int, string>(6, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = CloseRange(_cl);
            spell.TarEffAer = _target + MaxCal(1, 0, _cl) + " creature"+AddS(MaxCal(1, 0, _cl))+", no two of which can be more than 30ft apart";
            spell.Duration = DurationTime(_cl, _minute, 1);
            spell.SavingThrow = _willneg;
            spell.isHarmless = true;
            spell.SpellResistance = true;
            spell.ShortDescription = "As bear's endurance, affects " + MaxCal(1, 0, _cl) + " subject" + AddS(_cl) + ".";
            spell.Description = "Mass bear's endurance works like bear's endurance except that it affects multiple creatures.";

            return spell;
        }
        public Spell BestowCurse(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bestow Curse";
            spell.School.Add(_nec);
            spell.Subschool.Add(_blank);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(3, clr));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(4, sor));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(4, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.CastingTime = _1a;
            spell.Range = _tou;
            spell.TarEffAer = _target + "Creature touched";
            spell.Duration = _permanent;
            spell.SavingThrow = _willneg;
            spell.SpellResistance = true;
            spell.ShortDescription = "-6 to an ability; -4 in attack rolls, saves, and checks; or 50% chance of losing each action.";
            spell.Description = "You place a curse on the subject. Choose one of the following three effects.\r\n· –6 decrease to an ability score (minimum 1).\r\n· –4 penalty on attack rolls, saves, ability checks, and skill checks.\r\n· Each turn, the target has a 50% chance to act normally; otherwise, it takes no action.\r\nYou may also invent your own curse, but it should be no more powerful than those described above, and the DM has final say on the curse’s effect.\r\nThe curse bestowed by this spell cannot be dispelled, but it can be removed with a break enchantment, limited wish, miracle, remove curse, or wish spell.\r\nBestow curse counters remove curse.";

            return spell;
        }
        public Spell BigbysClenchedFist(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bigby's Clenched Fist";
            spell.School.Add(_evo);
            spell.Subschool.Add(_force);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(8, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(8, wiz));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(8, str));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_f + ": Arcane Focus: A leather glove.");
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _effect + "10-ft hand";
            spell.Duration = DurationTime(_cl, _rounds, 1) + " (D)";
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Large hand provides cover, pushes or, attacks your foes.";
            spell.Description = "This spell functions like Bigby’s interposing hand, except that the hand can interpose itself, push, or strike one opponent that  you select. The floating hand can move as  far as 60 feet and can attack in the same round. Since this hand is directed by you, its ability to notice or attack invisible or concealed creatures is no better than yours.\r\nThe hand attacks once per round, and its attack bonus equals "+MaxCal(1,0,_cl)+" + your Intelligence, Wisdom, or Charisma modifier (for a wizard, cleric, or sorcerer, respectively), +11 for the hand’s Strength score (33), –1 for being Large. The hand deals 1d8+11 points of damage on each attack, and any creature struck must make a Fortitude save (against this spell’s save DC) or be stunned for 1 round. Directing the spell to a new target is a move action.\r\nThe clenched fist can also interpose itself as Bigby’s interposing hand does, or it can bull rush an opponent as Bigby’s forceful hand does, but at a +15 bonus on the Strength check.\r\nClerics who cast this spell name it for their deities—Pelor’s clenched fist, for example.";

            return spell;
        }
        public Spell BigbysCrushingHand(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bigby's Crushing Hand";
            spell.School.Add(_evo);
            spell.Subschool.Add(_force);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(9, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(9, wiz));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(9, str));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_m + ": Arcane Material Component: The shell of an egg.");
            spell.Components.Add(_f + ": Arcane Focus: A glove of snakeskin.");
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _effect + "10-ft hand";
            spell.Duration = DurationTime(_cl, _rounds, 1) + " (D)";
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Large hand provides cover, pushes, or crushes your foes.";
            spell.Description = "This spell functions like Bigby’s interposing hand, except that the hand can interpose itself, push, or crush one opponent that you select.\r\nThe crushing hand can grapple an opponent like Bigby’s grasping hand does. Its grapple bonus equals "+MaxCal(1,0,_cl)+" + your Intelligence, Wisdom, or Charisma modifier (for a wizard, cleric, or sorcerer, respectively), +12 for the hand’s Strength score (35), +4 for being Large. The hand deals 2d6+12 points of damage (lethal, not nonlethal) on each successful grapple check against an opponent.\r\nThe crushing hand can also interpose itself as Bigby’s interposing hand does, or it can bull rush an opponent as Bigby’s forceful hand does, but at a +18 bonus.\r\nDirecting the spell to a new target is a move action.\r\nClerics who cast this spell name it for their deities—St. Cuthbert’s crushing hand, for example.";

            return spell;
        }
        public Spell BigbysForcefulHand(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bigby's Forceful Hand";
            spell.School.Add(_evo);
            spell.Subschool.Add(_force);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(6, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(6, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_f + ": Focus: A sturdy glove made of leather or heavy cloth.");
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _effect + "10-ft hand";
            spell.Duration = DurationTime(_cl, _rounds, 1) + " (D)";
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Hand pushes creatures away.";
            spell.Description = "This spell functions like Bigby’s interposing hand, except that the forceful hand pursues and pushes away the opponent that you designate. Treat this attack as a bull rush with a +14 bonus on the Strength check (+8 for Strength 27, +4 for being Large, and a +2 bonus for charging, which it always gets). The hand always moves with the opponent to push that target back the full distance allowed, and it has no speed limit. Directing the spell to a new target is a move action.\r\nA very strong creature could not push the hand out of its way because the latter would instantly reposition itself between the creature and you, but an opponent could push the hand up against you by successfully bull rushing it.";

            return spell;
        }
        public Spell BigbysGraspingHand(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bigby's Grasping Hand";
            spell.School.Add(_evo);
            spell.Subschool.Add(_force);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(7, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(7, wiz));
            spell.LevelAndClass.Insert(2, new KeyValuePair<int, string>(7, str));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_f + ": Arcane Focus: A leather glove.");
            spell.Components.Add(_d);
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _effect + "10-ft hand";
            spell.Duration = DurationTime(_cl, _rounds, 1) + " (D)";
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Hand provides cover, pushes, or grapples.";
            spell.Description = "This spell functions like Bigby’s interposing hand, except the hand can also grapple one opponent that you select. The grasping hand gets one grapple attack per round. Its attack bonus to make contact equals "+MaxCal(1, 0, _cl)+" + your Intelligence, Wisdom, or Charisma modifier (for wizards, clerics, and sorcerers, respectively), +10 for the hand’s Strength score (31), –1 for being Large. Its grapple bonus is this same figure, except with a +4 modifier for being Large instead of –1. The hand holds but does not harm creatures it grapples. Directing the spell to a new target is a move action.\r\nThe grasping hand can also bull rush an opponent as Bigby’s forceful hand does, but at a +16 bonus on the Strength check (+10 forStrength 35, +4 for being Large, and a +2 bonus for charging, which it always gets), or interpose itself as Bigby’s interposing hand does.\r\nClerics who cast this spell name it for their deities—Kord’s grasping hand, for example.";

            return spell;
        }
        public Spell BigbysInterposingHand(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "Bigby's Interposing Hand";
            spell.School.Add(_evo);
            spell.Subschool.Add(_force);
            spell.Descriptor.Add(_blank);
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(5, sor));
            spell.LevelAndClass.Insert(1, new KeyValuePair<int, string>(5, wiz));
            spell.Components.Add(_v);
            spell.Components.Add(_s);
            spell.Components.Add(_f + ": Arcane Focus: A soft glove.");
            spell.CastingTime = _1a;
            spell.Range = MediumRange(_cl);
            spell.TarEffAer = _effect + "10-ft hand";
            spell.Duration = DurationTime(_cl, _rounds, 1) + " (D)";
            spell.SavingThrow = "None";
            spell.SpellResistance = true;
            spell.ShortDescription = "Hand provides cover against one opponent.";
            spell.Description = "Bigby’s Interposing hand creates a Large magic hand that appears between you and one opponent. This floating, disembodied hand then moves to remain between the two of you, regardless of where you move or how the opponent tries to get around it, providing cover (+4 AC) for you against that opponent. Nothing can fool the hand—it sticks with the selected opponent in spite of darkness, invisibility, polymorphing, or any other attempt at hiding or disguise. The hand does not pursue an opponent, however.\r\nA Bigby’s hand is 10 feet long and about that wide with its fingers outstretched. It has as many hit points as you do when you’re undamaged, and its AC is 20 (–1 size, +11 natural). It takes damage as a normal creature, but most magical effects that don’t cause damage do not affect it. The hand never provokes attacks of opportunity from opponents. It cannot push through a wall of force or enter an antimagic field, but it suffers the full effect of a prismatic wall or prismatic sphere. The hand makes saving throws as its caster. Disintegrate or a successful dispel magic destroys it.\r\nAny creature weighing 2,000 pounds or less that tries to push past the hand is slowed to half its normal speed. The hand cannot reduce the speed of a creature weighing more than 2,000 pounds, but it still affects the creature’s attacks.\r\nDirecting the spell to a new target is a move action.";

            return spell;
        }
        #endregion
        /*
        public Spell Template(int _cl)
        {
            Spell spell = new Spell();

            spell.Name = "";
            spell.School.Add();
            spell.Subschool.Add();
            spell.Descriptor.Add();
            spell.LevelAndClass.Insert(0, new KeyValuePair<int, string>(, ));
            spell.Components.Add();
            spell.CastingTime = "";
            spell.Range = "";
            spell.TarEffAer = "";
            spell.Duration = "";
            spell.SavingThrow = "";
            spell.ShortDescription = "";
            spell.Description = "";

            return spell;
        }
        
        spell.isHarmless = true;
        spell.SpellResistance  = true;
        spell.onlyObject = true;
        
        */
    }
}
