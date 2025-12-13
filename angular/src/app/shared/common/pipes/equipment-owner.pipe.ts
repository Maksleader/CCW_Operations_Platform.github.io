import { Pipe, PipeTransform } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { Injector } from '@angular/core';
import { EquipmentOwner } from '@shared/service-proxies/service-proxies';

@Pipe({
    name: 'equipmentOwner'
})
export class EquipmentOwnerPipe extends AppComponentBase implements PipeTransform {
    constructor(injector: Injector) {
        super(injector);
    }

    transform(value: EquipmentOwner): string {
        switch (value) {
            case EquipmentOwner.Vendor:
                return this.l('Vendor');
            case EquipmentOwner.WFU13:
                return this.l('WFU13');
            case EquipmentOwner.Venue:
                return this.l('Venue');
            default:
                return '';
        }
    }
}
