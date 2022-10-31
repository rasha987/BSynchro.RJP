import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';
import { CustomerRoutingModule } from './customer-routing.module';

@NgModule({
  declarations: [AuthorComponent],
  imports: [SharedModule, CustomerRoutingModule, NgbDatepickerModule],
})
export class CustomerModule {}