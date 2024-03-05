export class BaseService {
    constructor(setAuthToken: (token:string)=>void, getAuthToken: ()=>string) {
        this.setAuthToken = setAuthToken;
        this.getAuthToken = getAuthToken;
    }
    
    protected static readonly _baseUrl: string = 'https://localhost:7138/api/';
    protected setAuthToken: (token:string)=>void;
    protected getAuthToken: ()=>string;

    protected async generateRequest<TReq,TRes>(url: string, method: 'POST'|'GET', body: TReq): Promise<TRes>  {
        let response = await fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
                'Authorization': this.getAuthToken()
            },
            body: JSON.stringify(body)
        });
        let json = await response.json();
        return JSON.parse(json) as TRes;
    }
}