import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StudentComponent } from './student.component';
import { CreateStudentDialogComponent } from "./create/create.component";
import { EditStudentDialogComponent } from "./edit/edit.component";
const routes: Routes = [
  {
    path: '',
    component: StudentComponent,
    pathMatch: 'full',
  },
  {
    path: 'create',
    component: CreateStudentDialogComponent,
    pathMatch: 'full',
  },
  {
    path: 'edit/:id',
    component: EditStudentDialogComponent,
    pathMatch: 'full',
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class StudentRoutingModule {}
