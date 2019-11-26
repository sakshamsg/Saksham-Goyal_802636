import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsignComponent } from './msign.component';

describe('MsignComponent', () => {
  let component: MsignComponent;
  let fixture: ComponentFixture<MsignComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsignComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsignComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
