import { LoginDTO } from '../DTOs/LoginDTO';
import { LoginResponseStatusEnum } from '../DTOs/LoginResponseStatusEnum';
import { BaseService } from './baseService';
import { Buffer } from 'buffer';

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
      case "First time login": return LoginResponseStatusEnum.firstTimeLogin;
      default: this.setAuthToken("Bearer "+text); return LoginResponseStatusEnum.success;
    }
  }

  public getRoles(): string[] {
    const roles = JSON.parse(Buffer.from(this.getAuthToken().split('.')[1], 'base64').toString())["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"];
    if (Array.isArray(roles)) return roles;
    return [roles];
  }

  public getUserId(): number {
    return JSON.parse(Buffer.from(this.getAuthToken().split('.')[1], 'base64').toString()).userId as number;
  }

  public allowRoles(roles: string[]): boolean {
    const userRoles = this.getRoles();
    for (let role of roles) {
      if (userRoles.includes(role)) return true;
    }
    return false;
  }

  public async logout(): Promise<void> {
    this.setAuthToken("");
  }
}