import { DialogComponent } from './dialog/dialog.component';
import { Injectable, ComponentFactoryResolver, ApplicationRef, Injector, ComponentRef, EmbeddedViewRef } from '@angular/core';
import { DialogModule } from './dialog.module';

@Injectable({
	providedIn: DialogModule
})
export class DialogService {

	dialogComponentRef: ComponentRef<DialogComponent>

	constructor(private componentFactoryResolver: ComponentFactoryResolver, private appRef: ApplicationRef,
		private injector: Injector) { }

	appendDialogComponentToBody():void {
		const componentFactory = this.componentFactoryResolver.resolveComponentFactory(DialogComponent);
		const componentRef = componentFactory.create(this.injector);
		this.appRef.attachView(componentRef.hostView);

		const domElement = (componentRef.hostView as EmbeddedViewRef<any>).rootNodes[0] as HTMLElement;
		document.body.appendChild(domElement);

		this.dialogComponentRef = componentRef;
	}
}
