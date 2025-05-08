using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Logic.Models {
    public class Establishment {
		private int _id;

		public int Id {
			get { return _id; }
			set { 
                _id = value;
			}
		}

		private string _luchthaven;

		public string Luchthaven {
			get { return _luchthaven; }
			set { _luchthaven = value; }
		}

		private string _straat;

		public string Straat {
			get { return _straat; }
			set { _straat = value; }
		}

		private int _postcode;

		public int Postcode {
			get { return _postcode; }
			set { _postcode = value; }
		}

		private string _land;

        public string Land {
			get { return _land; }
			set { _land = value; }
		}

        public Establishment(int id, string luchthaven, string straat, int postcode, string land) {
            Id = id;
            Luchthaven = luchthaven;
            Straat = straat;
            Postcode = postcode;
            Land = land;
        }

        public override bool Equals(object? obj) {
            return obj is Establishment establishment &&
                   Id == establishment.Id;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Id);
        }
    }
}
