import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { ApplicationHome } from './Home/app.home';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        ApplicationHome
    ],
    declarations: [ApplicationHome],
    bootstrap: [ApplicationHome]
})
export class AppModule {
    constructor() {
        console.log('start AppModule');
    }
}
