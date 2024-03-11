import { ResponseDTO } from "../DTOs/ResponseDTO";

type HttpMethod = 'POST'|'GET'|'DELETE'|'PUT';
export class BaseService {
    constructor(setAuthToken: (token:string)=>void, getAuthToken: ()=>string) {
        this.setAuthToken = setAuthToken;
        this.getAuthToken = getAuthToken;
    }
    
    protected static readonly _baseUrl: string = 'https://4ec0-78-83-182-147.ngrok-free.app/api/';
    protected setAuthToken: (token:string)=>void;
    protected getAuthToken: ()=>string;

    protected async generateRequest<TReq,TRes=undefined>(url: string, method: HttpMethod, body: TReq): Promise<ResponseDTO<TRes>>  {
        let response = await fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
                'Authorization': this.getAuthToken()
            },
            body: JSON.stringify(body)
        });
        let tmp!: TRes;
        let json:string|undefined = typeof tmp === "undefined" ? undefined : await response.json();
        const res = new ResponseDTO<TRes>();
        res.code=response.status;
        res.data= typeof json === "string" ? (JSON.parse(json) as TRes) : undefined;
        res.error = response.status == 200 ? undefined : await response.text();
        return res;
    }

    protected async generateRequestById<TRes>(url: string, method: HttpMethod, id: number): Promise<ResponseDTO<TRes>>  {
        let response = await fetch(url+`?id=${id}`, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
                'Authorization': this.getAuthToken()
            }
        });
        let json = await response.json();
        const res = new ResponseDTO<TRes>();
        res.code=response.status;
        res.data=JSON.parse(json) as TRes;
        return res;
    }

    protected async generateRequestNoParams<TRes>(url: string, method: HttpMethod): Promise<ResponseDTO<TRes>>  {
        let response = await fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
                'Authorization': this.getAuthToken()
            }
        });
        let json = await response.json();
        const res = new ResponseDTO<TRes>();
        res.code=response.status;
        res.data=JSON.parse(json) as TRes;
        return res;
    }
}
