using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Dalamud.RichPresence.Managers
{
    internal class PatchManager
    {
        private const string UNKNOWN_PATCH_NUMBER = "99999999.99";
        private List<string> patchNumbersInfo;
        private Dictionary<ulong, string> territoryPatchInfo;
  
        public PatchManager() {
            this.ReadPatchNumbersFile();
            this.ReadTerritoryToPatchDictFile();
        }

        private void ReadPatchNumbersFile()
        {
            patchNumbersInfo = JsonConvert.DeserializeObject<List<string>>(
                    File.ReadAllText(Path.Combine(
                            RichPresencePlugin.DalamudPluginInterface.AssemblyLocation.DirectoryName,
                            "Resources",
                            "data",
                            "patch_numbers.json")));
        }

        private void ReadTerritoryToPatchDictFile()
        {
            territoryPatchInfo = JsonConvert.DeserializeObject<Dictionary<ulong, string>>(
                    File.ReadAllText(Path.Combine(
                            RichPresencePlugin.DalamudPluginInterface.AssemblyLocation.DirectoryName,
                            "Resources",
                            "data",
                            "territory_to_patch.json")));
        }

        public List<string> GetPatchNumbersInfo()
        {
            return this.patchNumbersInfo;
        }

        public string GetTerritoryPatch(ulong territory)
        {
            string patchNumber;
            if (this.territoryPatchInfo.TryGetValue(territory, out patchNumber)) {
                return patchNumber;
            } else {
                return UNKNOWN_PATCH_NUMBER;
            }
        }
    }
}
