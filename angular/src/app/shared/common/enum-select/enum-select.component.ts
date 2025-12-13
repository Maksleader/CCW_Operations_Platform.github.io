import { Component, forwardRef, Injector, Input, OnInit } from '@angular/core';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms';
import { AppComponentBase } from '@shared/common/app-component-base';

export interface EnumOption {
    value: number;
    label: string;
}

@Component({
    selector: 'enum-select',
    templateUrl: './enum-select.component.html',
    styleUrls: ['./enum-select.component.less'],
    providers: [
        {
            provide: NG_VALUE_ACCESSOR,
            useExisting: forwardRef(() => EnumSelectComponent),
            multi: true,
        },
    ],
})
export class EnumSelectComponent extends AppComponentBase implements ControlValueAccessor, OnInit {
    @Input() enumType: any;
    @Input() placeholder: string = 'Select...';
    @Input() clearable: boolean = true;
    @Input() multiple: boolean = false;
    @Input() closeOnSelect: boolean = true;
    @Input() labelPrefix: string = '';
    @Input() includeAllOption: boolean = true;
    @Input() bindLabel: string = 'label';
    @Input() bindValue: string = 'value';

    options: EnumOption[] = [];
    value: any;
    disabled: boolean = false;

    private onChange: (value: any) => void = () => {};
    private onTouched: () => void = () => {};

    constructor(injector: Injector) {
        super(injector);
    }

    ngOnInit(): void {
        if (this.enumType) {
            this.options = this.getEnumOptions(this.enumType);
        }
    }

    writeValue(value: any): void {
        this.value = value;
    }

    registerOnChange(fn: any): void {
        this.onChange = fn;
    }

    registerOnTouched(fn: any): void {
        this.onTouched = fn;
    }

    setDisabledState(isDisabled: boolean): void {
        this.disabled = isDisabled;
    }

    onValueChange(value: any): void {
        this.value = value;
        this.onChange(value);
        this.onTouched();
    }

    private getEnumOptions(enumType: any): EnumOption[] {
        const options: EnumOption[] = [];
        
        for (const key in enumType) {
            if (!isNaN(Number(key))) {
                continue; // Skip numeric keys in reverse mapping
            }
            
            const value = enumType[key];
            if (typeof value === 'number') {
                options.push({
                    value: value,
                    label: this.l(this.labelPrefix + key),
                });
            }
        }
        
        return options;
    }
}
