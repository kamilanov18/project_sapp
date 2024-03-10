import { ChangePasswordDTO } from "../DTOs/ChangePasswordDTO";
import { UserDTO } from "../DTOs/UserDTO";
import { BaseService } from "./baseService";

export class UserService extends BaseService {
    protected static readonly _url: string = this._baseUrl+'Users/';

    public async get(id: number): Promise<UserDTO> {
        return await this.generateRequestById<UserDTO>(UserService._url+'Get','GET',id);
    }

    public async getAll(): Promise<UserDTO[]> {
        return await this.generateRequestNoParams<UserDTO[]>(UserService._url+'GetAll','GET');
    }

    public async register(dto: UserDTO): Promise<void> {
        await this.generateRequest<UserDTO,void>(UserService._url+'Register','POST',dto);
    }

    public async edit(dto: UserDTO): Promise<void> {
        await this.generateRequest<UserDTO,void>(UserService._url+'Edit','POST',dto);
    }

    public async changePassword(dto: ChangePasswordDTO): Promise<void> {
        await this.generateRequest<ChangePasswordDTO,void>(UserService._url+'ChangePassword','POST',dto);
    }

    public async delete(id: number): Promise<void> {
        await this.generateRequestById<void>(UserService._url+'Delete','DELETE',id);
    }
}