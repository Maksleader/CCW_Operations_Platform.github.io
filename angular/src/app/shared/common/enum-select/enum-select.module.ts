import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import { EnumSelectComponent } from './enum-select.component';

@NgModule({
    declarations: [EnumSelectComponent],
    imports: [CommonModule, FormsModule, NgSelectModule],
    exports: [EnumSelectComponent],
})
export class EnumSelectModule {}
