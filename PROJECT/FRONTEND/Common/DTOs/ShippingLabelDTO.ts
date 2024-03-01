﻿

module Models { 
    export class ShippingLabelDTO { 
        public senderClient: ClientDTO;
        public receiverClient: ClientDTO;
        public senderAddress: AddressDTO;
        public receiverAddress: AddressDTO;
        public packCount: number;
        public shipmentType: string;
        public weight: number;
        public shipmentDescription: string;
    }
}