

module Models { 
    export class AddressDTO { 
        public id: number;
        public city: CityDTO;
        public street: string;
        public num: string;
        public other: string;
        public location: LocationDTO;
        public fullAddress: string;
        public fullAddressEn: string;
        public quarter: string;
        public zip: string;
        public hezid: string;
    }
}