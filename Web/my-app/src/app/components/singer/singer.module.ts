import { NgModule } from '@angular/core';
import { SingerComponent } from './singer.component';
import { AddSingerComponent } from './add-singer/add-singer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CentricMatInputModule } from '@centric/ng-styleguide';

@NgModule({
  declarations: [SingerComponent, AddSingerComponent],
  imports: [FormsModule,
    ReactiveFormsModule,CentricMatInputModule ],
  providers: [],
})
export class SingerModule { }
