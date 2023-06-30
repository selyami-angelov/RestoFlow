export interface LoginFormProps {
  email: string
  password: string
}

export interface RegisterFormProps extends LoginFormProps {
  firstName: string
  lastName: string
  confirmPassword: string
}

export type LoginErrorsProps = Partial<LoginFormProps>
export type RegisterErrorsProps = Partial<RegisterFormProps>

export interface Product {
  id: number
  name: string
  description: string
  categoryId: number
  img: string
}

export interface Table {
  id: number
  tableNumber: number
  seats: number
}

export interface OccupiedTables {
  tableId: number
  userName: string
}
