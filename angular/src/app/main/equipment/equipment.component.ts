import { Component, Injector, OnInit, ViewChild, ViewEncapsulation } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import {
    EquipmentServiceProxy,
    EquipmentDto,
    EquipmentDivision,
    EquipmentOwner,
    EquipmentStatus,
    EquipmentInput,
} from '@shared/service-proxies/service-proxies';
import { LazyLoadEvent } from 'primeng/api';
import { Paginator } from 'primeng/paginator';
import { Table } from 'primeng/table';
import { finalize } from 'rxjs/operators';
import { PrimengTableHelper } from 'shared/helpers/PrimengTableHelper';
import { CreateOrEditEquipmentModalComponent } from './create-or-edit-equipment-modal.component';

@Component({
    templateUrl: './equipment.component.html',
    styleUrls: ['./equipment.component.less'],
    encapsulation: ViewEncapsulation.None,
    animations: [appModuleAnimation()],
})
export class EquipmentComponent extends AppComponentBase implements OnInit {
    @ViewChild('dataTable', { static: true }) dataTable: Table;
    @ViewChild('paginator', { static: true }) paginator: Paginator;
    @ViewChild('createOrEditEquipmentModal', { static: true }) createOrEditEquipmentModal: CreateOrEditEquipmentModalComponent;

    primengTableHelper = new PrimengTableHelper();

    equipmentDivision = EquipmentDivision;
    equipmentOwner = EquipmentOwner;
    equipmentStatus = EquipmentStatus;

    filters: EquipmentInput = new EquipmentInput();

    constructor(
        injector: Injector,
        private _equipmentService: EquipmentServiceProxy
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.filters.init();
    }

    getEquipments(event?: LazyLoadEvent) {
        if (this.primengTableHelper.shouldResetPaging(event)) {
            this.paginator.changePage(0);

            if (this.primengTableHelper.records && this.primengTableHelper.records.length > 0) {
                return;
            }
        }

        this.primengTableHelper.showLoadingIndicator();

        this._equipmentService.retrieveEquipments(this.filters)
            .pipe(finalize(() => this.primengTableHelper.hideLoadingIndicator()))
            .subscribe((result) => {
                this.primengTableHelper.totalRecordsCount = result.totalCount;
                this.primengTableHelper.records = result.items;
                this.primengTableHelper.hideLoadingIndicator();
            });
    }

    reloadPage(): void {
        this.paginator.changePage(this.paginator.getPage());
    }

    clearFilters(): void {
        this.filters = new EquipmentInput();
        this.filters.init();
        this.getEquipments();
    }

    createEquipment(): void {
        this.createOrEditEquipmentModal.show();
    }

    editEquipment(id: string): void {
        this.createOrEditEquipmentModal.show(id);
    }
}
