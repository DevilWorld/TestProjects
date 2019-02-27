import { Component, ChangeDetectionStrategy } from '@angular/core';

@Component({
	selector: 'app-root',
	templateUrl: './app.component.html',
	styleUrls: ['./app.component.css']	
})
export class AppComponent {
	title = 'changeDetectionStrategies';

	changeColor1: boolean = false;
	changeColor2: boolean = false;

	propChildValue = true;

	toggleColors() {
		this.changeColor1 = true;
	}

	toggle() {
		this.propChildValue = null;
		this.propChildValue = false;
	}

	ngDoCheck(){
		console.log('Change Detected in AppComponent');
	}
}
