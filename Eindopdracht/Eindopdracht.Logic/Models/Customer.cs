using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Logic.Models {
    class Customer {
		private int _id;

		public int Id {
			get { return _id; }
			set { _id = value; }
		}

		private string _voornaam;

		public string Voornaam {
			get { return _voornaam; }
			set { _voornaam = value; }
		}

		private string _achternaam;

		public string Achternaam {
			get { return _achternaam; }
			set { _achternaam = value; }
		}

		private string _email;

		public string Email {
			get { return _email; }
			set { _email = value; }
		}

		private int _postcode;

		public int Postcode {
			get { return _postcode; }
			set { _postcode = value; }
		}

		private string _woonplaats;

		public string Woonplaats {
			get { return _woonplaats; }
			set { _woonplaats = value; }
		}

		private string _land;

        public string Land {
			get { return _land; }
			set { _land = value; }
		}

        public Customer(int id, string voornaam, string achternaam, string email, int postcode, string woonplaats, string land) {
            Id = id;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Postcode = postcode;
            Woonplaats = woonplaats;
            Land = land;
        }

        public override bool Equals(object? obj) {
            return obj is Customer customer &&
                   Id == customer.Id;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Id);
        }
    }
}
