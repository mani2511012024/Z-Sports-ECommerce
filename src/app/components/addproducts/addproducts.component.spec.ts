import { ComponentFixture } from '@angular/core/testing';
import { TestBed } from '@angular/core/testing';
import { AddproductsComponent } from './addproducts.component';

describe('AddproductsComponent', () => {
  let component: AddproductsComponent;
  let fixture: ComponentFixture<AddproductsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddproductsComponent],
    });
    fixture = TestBed.createComponent(AddproductsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
