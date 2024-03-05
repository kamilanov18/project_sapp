import { BaseService } from "./baseService";
import { LoginDTO } from '../DTOs/LoginDTO';

export class AuthService extends BaseService{
    protected static readonly _url: string = this._baseUrl+'Auth/';
    public async login(dto:LoginDTO): Promise<void> {
        let token = await fetch(AuthService._url+'Login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(dto)
        });
        console.log(token);
        this.setAuthToken("Bearer "+token.toString());
    }

    public async logout(): Promise<void> {
        this.setAuthToken("");
    }
}