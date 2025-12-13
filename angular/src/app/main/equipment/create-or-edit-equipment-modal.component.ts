import { Component, EventEmitter, Injector, OnInit, Output, ViewChild } from '@angular/core';
import { AppComponentBase } from '@shared/common/app-component-base';
import { ModalDirective } from 'ngx-bootstrap/modal';
import {
    EquipmentServiceProxy,
    CreateEditEquipmentDto,
    EquipmentDivision,
    EquipmentOwner,
    EquipmentStatus,
} from '@shared/service-proxies/service-proxies';
import { finalize } from 'rxjs/operators';

@Component({
    selector: 'create-or-edit-equipment-modal',
    templateUrl: './create-or-edit-equipment-modal.component.html',
})
export class CreateOrEditEquipmentModalComponent extends AppComponentBase implements OnInit {
    @ViewChild('createOrEditModal', { static: true }) modal: ModalDirective;
    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active = false;
    saving = false;

    equipment: CreateEditEquipmentDto = new CreateEditEquipmentDto();

    // Enums for template
    equipmentDivision = EquipmentDivision;
    equipmentOwner = EquipmentOwner;
    equipmentStatus = EquipmentStatus;

    constructor(
        injector: Injector,
        private _equipmentService: EquipmentServiceProxy
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.equipment = new CreateEditEquipmentDto();
    }

    show(equipmentId?: string): void {
        if (!equipmentId) {
            this.equipment = new CreateEditEquipmentDto();
            this.equipment.init({ division: EquipmentDivision.Cleaning, owner: EquipmentOwner.Vendor, status: EquipmentStatus.InStorage });
            this.active = true;
            this.modal.show();
        } else {
            this._equipmentService.getEquipmentForEdit(equipmentId).subscribe((result) => {
                this.equipment = result;
                this.active = true;
                this.modal.show();
            });
        }
    }

    save(): void {
        this.saving = true;

        const saveObservable = this.equipment.id
            ? this._equipmentService.updateEquipment(this.equipment)
            : this._equipmentService.createEquipment(this.equipment);

        saveObservable
            .pipe(
                finalize(() => {
                    this.saving = false;
                })
            )
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
