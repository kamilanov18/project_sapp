import { OrderDTO } from "../DTOs/OrderDTO";
import { OrderDetailsDTO } from "../DTOs/OrderDetailsDTO";
import { ResponseDTO } from "../DTOs/ResponseDTO";
import { BaseService } from "./baseService";

export class OrdersService extends BaseService {
    protected static readonly _url: string = this._baseUrl+'Orders/';

    public async get(id: number): Promise<ResponseDTO<OrderDetailsDTO>> {
        return this.generateRequestById<OrderDetailsDTO>(OrdersService._url+'Get','GET',id);
    }

    public async getAll(): Promise<ResponseDTO<OrderDTO[]>> {
        return this.generateRequestNoParams<OrderDTO[]>(OrdersService._url+'GetAll','GET');
    }

    public async edit(dto: OrderDetailsDTO): Promise<ResponseDTO<undefined>> {
        return this.generateRequest<OrderDetailsDTO>(OrdersService._url+'Edit','POST',dto);
    }
}