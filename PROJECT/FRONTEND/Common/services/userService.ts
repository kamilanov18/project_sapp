import { ResponseDTO } from "../DTOs/ResponseDTO";
import { ChangePasswordDTO } from "../DTOs/ChangePasswordDTO";
import { UserDTO } from "../DTOs/UserDTO";
import { BaseService } from "./baseService";

export class UserService extends BaseService {
    protected static readonly _url: string = this._baseUrl+'Users/';

    public async get(id: number): Promise<ResponseDTO<UserDTO>> {
        return this.generateRequestById<UserDTO>(UserService._url+'Get','GET',id);
    }

    public async getAll(): Promise<ResponseDTO<UserDTO[]>> {
        return this.generateRequestNoParams<UserDTO[]>(UserService._url+'GetAll','GET');
    }

    public async register(dto: UserDTO): Promise<ResponseDTO<undefined>> {
        return this.generateRequest<UserDTO>(UserService._url+'Register','POST',dto);
    }

    public async edit(dto: UserDTO): Promise<ResponseDTO<undefined>> {
        return this.generateRequest<UserDTO>(UserService._url+'Edit','POST',dto);
    }

    public async changePassword(dto: ChangePasswordDTO): Promise<ResponseDTO<undefined>> {
        return this.generateRequest<ChangePasswordDTO>(UserService._url+'ChangePassword','POST',dto);
    }

    public async delete(id: number): Promise<ResponseDTO<void>> {
        return this.generateRequestById<void>(UserService._url+'Delete','DELETE',id);
    }
}