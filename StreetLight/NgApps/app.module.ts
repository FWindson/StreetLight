import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { ApplicationHome } from './home/app.home';

@NgModule({
    imports: [
        BrowserModule
    ],
    declarations: [ApplicationHome],
    bootstrap: [ApplicationHome]
})
export class AppModule {
}
