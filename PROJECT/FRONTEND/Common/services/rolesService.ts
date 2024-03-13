import { ResponseDTO } from "../DTOs/ResponseDTO";
import { NomenclatureDTO } from "../DTOs/NomenclatureDTO";
import { UpdateUserRolesDTO } from "../DTOs/UpdateUserRolesDTO";
import { BaseService } from "./baseService";
import { UserDTO } from "../DTOs/UserDTO";

export class RolesService extends BaseService {
    protected static readonly _url: string = this._baseUrl+'Roles/';

    public async get(id: number): Promise<ResponseDTO<NomenclatureDTO<number>>> {
        return this.generateRequestById<NomenclatureDTO<number>>(RolesService._url+'Get','GET',id);
    }

    public async getAll(): Promise<ResponseDTO<NomenclatureDTO<number>[]>> {
        return this.generateRequestNoParams<NomenclatureDTO<number>[]>(RolesService._url+'GetAll','GET');
    }

    public async edit(dto: NomenclatureDTO<number>): Promise<ResponseDTO<undefined>> {
        return this.generateRequest<NomenclatureDTO<number>>(RolesService._url+'Edit','POST',dto);
    }

    public async delete(id: number): Promise<ResponseDTO<void>> {
        return this.generateRequestById<void>(RolesService._url+'Delete','DELETE',id);
    }

    public async updateUserRoles(dto: UpdateUserRolesDTO): Promise<ResponseDTO<void>> {
        return this.generateRequest<UpdateUserRolesDTO>(RolesService._url+'UpdateUserRoles','POST',dto);
    }

    public async getAUsersRoles(id: number): Promise<ResponseDTO<NomenclatureDTO<number>[]>> {
        return this.generateRequestById<NomenclatureDTO<number>[]>(RolesService._url+'GetAUsersRoles','GET',id);
    }

    public async getAllUsersInRole(id: number): Promise<ResponseDTO<UserDTO[]>> {
        return this.generateRequestById<UserDTO[]>(RolesService._url+'GetAllUsersInRole','GET',id);
    }
}