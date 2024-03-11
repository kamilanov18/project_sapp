export class ResponseDTO<T> {
    constructor(obj?:Partial<ResponseDTO<T>>) {
        Object.assign(this, obj);
    }
    public data!:T|undefined;
    public code!:number;
    public error?:string;
} 