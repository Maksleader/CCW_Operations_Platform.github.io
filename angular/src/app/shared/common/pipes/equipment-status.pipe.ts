import { Pipe, PipeTransform } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { Injector } from '@angular/core';
import { EquipmentStatus } from '@shared/service-proxies/service-proxies';

@Pipe({
    name: 'equipmentStatus'
})
export class EquipmentStatusPipe extends AppComponentBase implements PipeTransform {
    constructor(injector: Injector) {
        super(injector);
    }

    transform(value: EquipmentStatus): string {
        switch (value) {
            case EquipmentStatus.InStorage:
                return this.l('InStorage');
            case EquipmentStatus.OnSite:
                return this.l('OnSite');
            case EquipmentStatus.Removed:
                return this.l('Removed');
            case EquipmentStatus.Broken:
                return this.l('Broken');
            default:
                return '';
        }
    }
}
