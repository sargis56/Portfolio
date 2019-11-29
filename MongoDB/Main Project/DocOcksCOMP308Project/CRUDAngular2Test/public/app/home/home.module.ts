﻿import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HomeRoutes } from './home.routes';
import { HomeComponent } from './home.component';
@NgModule({
    imports: [
        FormsModule,
        CommonModule,
        RouterModule.forChild(HomeRoutes),
    ],
    declarations: [
        HomeComponent,
    ]
})
export class HomeModule { }
