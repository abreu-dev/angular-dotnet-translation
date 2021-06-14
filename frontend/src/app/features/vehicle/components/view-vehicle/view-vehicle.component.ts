import { Component } from '@angular/core';

import { BsModalRef } from 'ngx-bootstrap/modal';

import { Vehicle } from '../../shared/models/vehicle';

import { masks } from '../../../../shared/utils/masks';

@Component({
    selector: 'app-view-vehicle',
    templateUrl: './view-vehicle.component.html'
})
export class ViewVehicleComponent {
    public vehicle!: Vehicle;
    public plateMask: string = masks.plate;

    constructor(
        private bsModalRef: BsModalRef
    ) { }

    public close(): void {
        this.bsModalRef.hide();
    }
}
