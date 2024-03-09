

export class AddressDTO { 
    public id: number | null;
    public city: CityDTO;
    public street: string | null;
    public num: string | null;
    public other: string | null;
    public location: LocationDTO;
    public fullAddress: string | null;
    public fullAddressEn: string | null;
    public quarter: string | null;
    public zip: string | null;
    public hezid: string | null;
}
