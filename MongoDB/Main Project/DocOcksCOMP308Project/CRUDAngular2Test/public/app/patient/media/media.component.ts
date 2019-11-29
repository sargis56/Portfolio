import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { PatientService } from '../patient.service';
@Component({
    selector: 'create',
    templateUrl: 'app/patient/media/media.template.html'
})
export class CreateComponent {
    patient: any = {};
    errorMessage: string;
    constructor(private _router: Router,
        private _patientsService: PatientService) { }
    create() {
        this._patientsService
            .create(this.patient)
            .subscribe(createdPatient => this._router.navigate(['/Patient',
                createdPatient._id]),
            error => this.errorMessage = error);
    }
}
