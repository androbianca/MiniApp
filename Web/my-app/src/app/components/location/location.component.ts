import { Component, OnInit } from '@angular/core';
import { DialogService } from '@centric/ng-styleguide';
import { MapComponent } from './map/map.component';

@Component({
  selector: 'app-location',
  templateUrl: './location.component.html',
  styleUrls: ['./location.component.scss']
})
export class LocationComponent implements OnInit {
 
  dialogRef: any;

  constructor(private dialogService: DialogService) {}
  ngOnInit(): void {
    this.dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`); // Pizza!
    });
  }

  openModal() {
    this.dialogService.message(MapComponent, {
      data: { name: 'Dialog message',
              height: 200,
              width:200 }
    });
  }

  closeDialog(): void {
    this.dialogRef.close();

  }
}
