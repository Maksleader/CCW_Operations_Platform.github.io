import { Pipe, PipeTransform } from '@angular/core';
import { EquipmentStatus } from '@shared/service-proxies/service-proxies';

@Pipe({
    name: 'equipmentStatusClass'
})
export class EquipmentStatusClassPipe implements PipeTransform {
    transform(value: EquipmentStatus): string {
        switch (value) {
            case EquipmentStatus.InStorage:
                return 'badge-info';
            case EquipmentStatus.OnSite:
                return 'badge-success';
            case EquipmentStatus.Removed:
                return 'badge-warning';
            case EquipmentStatus.Broken:
                return 'badge-danger';
            default:
                return 'badge-secondary';
        }
    }
}
