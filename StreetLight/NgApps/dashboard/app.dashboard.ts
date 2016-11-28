import { Component } from '@angular/core';

@Component({
    template: `
        <h3>{{title}}</h3>
    `
})
export class DashBoard {
    title: string;

    constructor() {
        this.title = "工作台";
    }
}