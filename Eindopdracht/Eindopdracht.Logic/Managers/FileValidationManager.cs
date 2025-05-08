using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Logic.Managers {
    public class FileValidationManager {
        public bool ValidatePath(List<string> paths) {
            foreach (var path in paths) {
                if (!File.Exists(path) || Path.GetExtension(path).ToLower() != ".csv") return false;
            }
            return true;
        }
    }
}
