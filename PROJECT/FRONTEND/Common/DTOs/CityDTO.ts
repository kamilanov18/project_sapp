

module Models { 
    export class CityDTO { 
        public country: CountryDTO;
        public name: string;
        public postCode: string;
        public nameEn: string;
        public regionName: string;
        public regionNameEn: string;
        public phoneCode: string;
        public location: LocationDTO;
        public expressCityDeliveries: boolean;
        public monday: boolean;
        public tuesday: boolean;
        public wednesday: boolean;
        public thursday: boolean;
        public friday: boolean;
        public saturday: boolean;
        public sunday: boolean;
        public serviceDays: number;
        public zoneId: number;
        public zoneName: string;
        public zoneNameEn: string;
    }
}