import { NomenclatureDTO } from "../DTOs/NomenclatureDTO";
import { ResponseDTO } from "../DTOs/ResponseDTO";
import { BaseService } from "./baseService";

export class NomenclaturesService extends BaseService
{
    protected static readonly _url: string = this._baseUrl+'Nomenclatures/';

    public async getEcontCountries(): Promise<ResponseDTO<NomenclatureDTO<string>[]>>
    {
        return this.generateRequestNoParams<NomenclatureDTO<string>[]>(NomenclaturesService._url+'GetEcontCountries','GET');
    }

    public async GetEcontCities(countryCode: string): Promise<ResponseDTO<NomenclatureDTO<number>[]>>
    {
        return this.generateRequestByQuery<NomenclatureDTO<number>[]>(NomenclaturesService._url+'GetEcontCities','GET',`countryCode=${countryCode}`);
    }

    public async GetEcontStreets(cityId:number): Promise<ResponseDTO<NomenclatureDTO<number>[]>>
    {
        return this.generateRequestById<NomenclatureDTO<number>[]>(NomenclaturesService._url+'GetEcontStreets','GET',cityId);
    }
}