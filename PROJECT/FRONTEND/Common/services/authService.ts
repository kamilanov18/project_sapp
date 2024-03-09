import { LoginDTO } from '../DTOs/LoginDTO';
import { LoginResponseStatusEnum } from '../DTOs/LoginResponseStatusEnum';
import { BaseService } from './baseService';

export class AuthService extends BaseService {
  protected static readonly _url: string = this._baseUrl+'Auth/';
  
  public async login(dto:LoginDTO): Promise<LoginResponseStatusEnum> {
    console.log(dto);
    let res = await fetch(AuthService._url+'Login', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(dto)
    });
    const text = await res.text();
    switch (text) {
      case "Incorrect password": return LoginResponseStatusEnum.invalidPassword;
      case "No such email found": return LoginResponseStatusEnum.noEmailFound;
      default: this.setAuthToken("Bearer "+text); return LoginResponseStatusEnum.success;
    }
  }

  public async logout(): Promise<void> {
    this.setAuthToken("");
  }
}