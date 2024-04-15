export class CacheService {
    private _set:(key: string, value: any)=>void;
    private _get:(key: string)=>any;

    public constructor(set:(key: string, value: any)=>void, get:(key: string)=>any) {
        this._set = set;
        this._get = get;
    }

    public set(key: string, value: any): void {
        this._set(key, value);
    }

    public get(key: string): any {
        return this._get(key);
    }

    public processObject(key:string,object:any) {
        let objHash = this.hashCode(JSON.stringify(object));
        let keyHash = this.hashCode(JSON.stringify(this._get(key)));
        if(objHash == keyHash) return;
        this._set(key,object);
    }

    private hashCode(string:string){
        let hash = 0;
        for (let i = 0; i < string.length; i++) {
            let code = string.charCodeAt(i);
            hash = ((hash<<5)-hash)+code;
            hash = hash & hash;
        }
        return hash;
    }
}