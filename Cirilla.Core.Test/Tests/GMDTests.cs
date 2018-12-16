using System.Linq;
using Cirilla.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cirilla.Core.Test.Tests
{
    [TestClass]
    public class GMDTests
    {
        [TestMethod]
        public void Load__em_names_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/em_names_eng.gmd"));
        }

        [TestMethod]
        public void Load__q00503_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/quest/q00503_eng.gmd"));
        }

        [TestMethod]
        public void Load__item_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/item_eng.gmd"));
        }

        [TestMethod]
        public void Load__armor_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/steam/armor_eng.gmd"));
        }

        [TestMethod]
        public void Load__action_trial_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/action_trial_eng.gmd"));
            //Assert.AreEqual(gmd.Entries[3].Value, "©CAPCOM CO., LTD. ALL RIGHTS RESERVED.");
        }

        [TestMethod]
        public void Load__action_trial_ara()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/action_trial_ara.gmd"));
            //Assert.AreEqual(gmd.Entries[3].Value, "©CAPCOM CO., LTD. ALL RIGHTS RESERVED.");
        }

        [TestMethod]
        public void Load__cm_facility_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/cm_facility_eng.gmd"));
        }

        [TestMethod]
        public void Load__cm_facility_kor()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/cm_facility_kor.gmd"));
        }

        [TestMethod]
        public void Load__cm_status_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/cm_status_eng.gmd"));
        }

        [TestMethod]
        public void Load__cm_chat_eng()
        {
            GMD gmd = new GMD(Utility.GetFullPath(@"chunk5/common/text/cm_chat_eng.gmd"));
        }

        [TestMethod]
        public void Rebuild__em_names_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk0/common/text/em_names_eng.gmd");
            string rebuildPath = "rebuild__em_names_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void Rebuild__q00503_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk0/common/text/quest/q00503_eng.gmd");
            string rebuildPath = "rebuild__q00503_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void Rebuild__item_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk0/common/text/item_eng.gmd");
            string rebuildPath = "rebuild__item_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void Rebuild__action_trial_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk0/common/text/action_trial_eng.gmd");
            string rebuildPath = "rebuild__action_trial_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void Rebuild__wep_series_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk0/common/text/steam/wep_series_eng.gmd");
            string rebuildPath = "rebuild__wep_series_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void Rebuild__w_sword_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk0/common/text/steam/w_sword_eng.gmd");
            string rebuildPath = "rebuild__w_sword_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void Rebuild__cm_status_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk0/common/text/cm_status_eng.gmd");
            string rebuildPath = "rebuild__cm_status_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void Rebuild__cm_chat_eng()
        {
            string origPath = Utility.GetFullPath(@"chunk5/common/text/cm_chat_eng.gmd");
            string rebuildPath = "rebuild__cm_chat_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.Save(rebuildPath);

            if (!Utility.CheckFilesAreSame(origPath, rebuildPath))
                Assert.Fail("Hash doesn't match!");
        }

        [TestMethod]
        public void AddString__q00503_eng()
        {
            string newPath = "addstring__q00503_eng.gmd";

            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/quest/q00503_eng.gmd"));
            gmd.AddString("MY_NEW_STRING", "New string text....");
            gmd.Save(newPath);

            GMD oldGmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/quest/q00503_eng.gmd"));
            GMD newGmd = new GMD(newPath);

            Assert.IsTrue(oldGmd.Header.KeyCount < newGmd.Header.KeyCount);
            Assert.IsTrue(oldGmd.Header.KeyBlockSize < newGmd.Header.KeyBlockSize);
            Assert.IsTrue(oldGmd.Header.StringCount < newGmd.Header.StringCount);
            Assert.IsTrue(oldGmd.Header.StringBlockSize < newGmd.Header.StringBlockSize);
            Assert.IsNotNull(newGmd.Entries.FirstOrDefault(x => x.Value == "New string text...."));
        }

        [TestMethod]
        public void AddStringAt__armor_eng()
        {
            string newPath = "addstringat__armor_eng.gmd";

            GMD gmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/steam/armor_eng.gmd"));

            // Find index
            var entryToFind = gmd.Entries.OfType<GMD_Entry>().FirstOrDefault(x => x.Key == "AM_ACCE001_NAME");
            int idx = gmd.Entries.IndexOf(entryToFind);

            gmd.AddString("AM_ACCE001_EXP", "Description for AM_ACCE001_NAME", idx + 1);
            gmd.Save(newPath);

            GMD oldGmd = new GMD(Utility.GetFullPath(@"chunk0/common/text/quest/q00503_eng.gmd"));
            GMD newGmd = new GMD(newPath);

            Assert.IsTrue(oldGmd.Header.KeyCount < newGmd.Header.KeyCount);
            Assert.IsTrue(oldGmd.Header.KeyBlockSize < newGmd.Header.KeyBlockSize);
            Assert.IsTrue(oldGmd.Header.StringCount < newGmd.Header.StringCount);
            Assert.IsTrue(oldGmd.Header.StringBlockSize < newGmd.Header.StringBlockSize);
            Assert.IsNotNull(newGmd.Entries.FirstOrDefault(x => x.Value == "Description for AM_ACCE001_NAME"));
        }

        [TestMethod]
        public void ReaddString__w_sword_eng()
        {
            // This won't display correctly in game, because the string order DOES matter
            string origPath = Utility.GetFullPath(@"chunk0/common/text/steam/w_sword_eng.gmd");
            string newPath = "removestring__w_sword_eng.gmd";
            string readdPath = "readdstring__w_sword_eng.gmd";

            GMD gmd = new GMD(origPath);
            gmd.RemoveString("WP_WSWD_044_NAME");
            gmd.Save(newPath);

            GMD newGmd = new GMD(newPath);

            newGmd.AddString("WP_WSWD_044_NAME", "My new string");
            newGmd.Save(readdPath);
        }
    }
}
