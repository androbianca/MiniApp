import { NgModule } from '@angular/core';
import { SingerComponent } from './singer.component';
import { AddSingerComponent } from './add-singer/add-singer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [SingerComponent, AddSingerComponent],
  imports: [FormsModule,
    ReactiveFormsModule,],
  providers: [],
})
export class SingerModule { }
