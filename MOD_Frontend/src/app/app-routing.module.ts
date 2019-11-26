import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { HomepageComponent } from './homepage/homepage.component';
import { CoursesComponent } from './courses/courses.component';
import { UloginComponent } from './ulogin/ulogin.component';
import { UsignComponent } from './usign/usign.component';
import { UdashComponent } from './udash/udash.component';
import { MsignComponent } from './msign/msign.component';
import { MprofComponent } from './mprof/mprof.component';
import { UprofComponent } from './uprof/uprof.component';
import { CrnttrComponent } from './crnttr/crnttr.component';
import { ComptrComponent } from './comptr/comptr.component';
import { FindtrComponent } from './findtr/findtr.component';
import { ConctusComponent } from './conctus/conctus.component';
import { AdmindashComponent } from './admindash/admindash.component';
import { AdminStudentComponent } from './admin-student/admin-student.component';
import { AdminMentorComponent } from './admin-mentor/admin-mentor.component';
import { AdmintechComponent } from './admintech/admintech.component';
import { SearchComponent } from './search/search.component';
import { MdashComponent } from './mdash/mdash.component';


const routes: Routes = [
   {path: '',component:HomepageComponent },
  {path: 'abt',component: AboutComponent },
  {path: 'crs',component: CoursesComponent },
  {path: 'ctus',component: ConctusComponent },
  {path: 'addsh',component: AdmindashComponent , 
  children: [
    {path: 'adst',component: AdminStudentComponent },
    {path: 'adtch',component: AdmintechComponent },
    {path: 'admn',component: AdminMentorComponent }
  ]},
  {path: 'ul',component: UloginComponent },
  {path: 'us',component: UsignComponent },
  {path: 'udsh',component: UdashComponent },
  {path: 'mdsh',component: MdashComponent },
  {path: 'ms',component: MsignComponent },
  {path: 'mpro',component: MprofComponent },
  {path: 'upro',component: UprofComponent },
    {path: 'cotr',component: ComptrComponent },
  {path: 'hm',component: HomepageComponent},
  {path: 'srch',component: SearchComponent},
  {path: 'ftr',component: FindtrComponent},
  {path: 'crtr',component: CrnttrComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
