import { ResponseDTO } from "../DTOs/ResponseDTO";

type HttpMethod = 'POST'|'GET'|'DELETE'|'PUT';
export class BaseService {
    constructor(setAuthToken: (token:string)=>void, getAuthToken: ()=>string) {
        this.setAuthToken = setAuthToken;
        this.getAuthToken = getAuthToken;
    }
    
    protected static readonly _baseUrl: string = 'https://6ff9-78-83-182-147.ngrok-free.app/api/';
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
        return this.processResponse<TRes>(response);
    }

    protected async generateRequestById<TRes>(url: string, method: HttpMethod, id: number): Promise<ResponseDTO<TRes>>  {
        let response = await fetch(url+`?id=${id}`, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
                'Authorization': this.getAuthToken()
            }
        });
        console.log(url+`?id=${id}`);
        console.log(response);
        return this.processResponse<TRes>(response);
    }

    protected async generateRequestByQuery<TRes>(url: string, method: HttpMethod, query:string): Promise<ResponseDTO<TRes>>  {
        let response = await fetch(url+`?${query}`, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
                'Authorization': this.getAuthToken()
            }
        });
        //console.log(response);
        return this.processResponse<TRes>(response);
    }

    protected async generateRequestNoParams<TRes>(url: string, method: HttpMethod): Promise<ResponseDTO<TRes>>  {
        let response = await fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
                'Authorization': this.getAuthToken()
            }
        });
        return this.processResponse<TRes>(response);
    }

    private async processResponse<TRes>(response: Response): Promise<ResponseDTO<TRes>> {
        const res = new ResponseDTO<TRes>();
        res.code  = response.status;
        res.data  = response.status == 200 ? (await response.json() as TRes) : undefined;
        res.error = response.status == 200 ? undefined : await response.text();
        //console.log(res);
        return res;
    }
}
