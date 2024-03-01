import { BaseService } from "./baseService";
import * as SecureStore from 'expo-secure-store';

export class AuthService extends BaseService{
    protected static readonly _url: string = this._baseUrl+'Auth/';
    public async login(username: string, password: string): Promise<void> {
        let token = await fetch(AuthService._url+'Login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({username, password})
        });
        console.log(token);
        await SecureStore.setItemAsync('auth', "Bearer "+token.toString());
    }

    public async logout(): Promise<void> {
        await SecureStore.setItemAsync('auth', "");
    }
}