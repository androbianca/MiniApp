import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { GoogleMap, } from '@angular/google-maps';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Coordinates } from './coordinates';

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss']
})
export class MapComponent implements OnInit {
  @ViewChild(GoogleMap, { static: false }) map: GoogleMap

  zoom = 12
  markers = []
  latitude: number;
  longitude: number;
  options: google.maps.MapOptions = {
    zoomControl: false,
    scrollwheel: false,
    disableDoubleClickZoom: true,
    mapTypeId: 'hybrid',
    maxZoom: 15,
    minZoom: 8,
  }
  center: any

  constructor(@Inject(MAT_DIALOG_DATA) public data: any,public dialogRef: MatDialogRef<MapComponent>) {}
  
  ngOnInit(): void {
    navigator.geolocation.getCurrentPosition((position) => {
      this.center = {
        lat: position.coords.latitude,
        lng: position.coords.longitude,
      }
    })
  }

  zoomIn(): void {
    if (this.zoom < this.options.maxZoom) this.zoom++
  }

  zoomOut(): void {
    if (this.zoom > this.options.minZoom) this.zoom--
  }

  click(event: any): void {
    this.markers = []
    this.markers.push({
      position: {
        lat: +event.latLng.lat(),
        lng: +event.latLng.lng()
      },
      options: {
        animation: google.maps.Animation.BOUNCE,
      },
    })
    this.latitude = event.latLng.lat();
    this.longitude = event.latLng.lng();
  }

  closeDialog(): void {
    const coordinates = new Coordinates({
      latitude: this.latitude,
      longitude: this.longitude
    })
    this.dialogRef.close(coordinates);
  }
}
