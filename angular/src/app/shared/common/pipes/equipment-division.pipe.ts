import { Pipe, PipeTransform } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { Injector } from '@angular/core';
import { EquipmentDivision } from '@shared/service-proxies/service-proxies';

@Pipe({
    name: 'equipmentDivision'
})
export class EquipmentDivisionPipe extends AppComponentBase implements PipeTransform {
    constructor(injector: Injector) {
        super(injector);
    }

    transform(value: EquipmentDivision): string {
        switch (value) {
            case EquipmentDivision.Cleaning:
                return this.l('Cleaning');
            case EquipmentDivision.Waste:
                return this.l('Waste');
            case EquipmentDivision.Catering:
                return this.l('Catering');
            case EquipmentDivision.FB:
                return this.l('FB');
            case EquipmentDivision.AdminAndSupplyChain:
                return this.l('AdminAndSupplyChain');
            case EquipmentDivision.Others:
                return this.l('Others');
            default:
                return '';
        }
    }
}
