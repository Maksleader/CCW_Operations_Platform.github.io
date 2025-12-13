import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { ModalModule } from 'ngx-bootstrap/modal';
import { AppCommonModule } from '@app/shared/common/app-common.module';
import { UtilsModule } from '@shared/utils/utils.module';
import { TableModule } from 'primeng/table';
import { PaginatorModule } from 'primeng/paginator';
import { SubheaderModule } from '@app/shared/common/sub-header/subheader.module';
import { EnumSelectModule } from '@app/shared/common/enum-select/enum-select.module';
import { EquipmentRoutingModule } from './equipment-routing.module';
import { EquipmentComponent } from './equipment.component';
import { CreateOrEditEquipmentModalComponent } from './create-or-edit-equipment-modal.component';
import { EquipmentDivisionPipe } from '@app/shared/common/pipes/equipment-division.pipe';
import { EquipmentOwnerPipe } from '@app/shared/common/pipes/equipment-owner.pipe';
import { EquipmentStatusPipe } from '@app/shared/common/pipes/equipment-status.pipe';
import { EquipmentStatusClassPipe } from '@app/shared/common/pipes/equipment-status-class.pipe';

@NgModule({
    declarations: [
        EquipmentComponent,
        CreateOrEditEquipmentModalComponent,
        EquipmentDivisionPipe,
        EquipmentOwnerPipe,
        EquipmentStatusPipe,
        EquipmentStatusClassPipe,
    ],
    imports: [
        CommonModule,
        FormsModule,
        NgSelectModule,
        ModalModule.forRoot(),
        AppCommonModule,
        UtilsModule,
        TableModule,
        PaginatorModule,
        SubheaderModule,
        EnumSelectModule,
        EquipmentRoutingModule,
    ],
})
export class EquipmentModule {}
