import { Button } from 'flowbite-react'
import img from '../../../public/assets/burger.jpg'
import { Order, Product } from '../../pages/models'
import { HiCheck } from 'react-icons/hi'
import { usePost } from '../../hooks/use-post'
import { usePut } from '../../hooks/use-put'

interface Props extends Order {
  product?: Product
}

export const OrderCard = ({ createdBy, createdDate, productQuantity, editedBy, editedDate, product, id }: Props) => {
  const { data, putData } = usePut({ manual: true })

  const handleDoneClick = () => {
    const endpoint = `/orders/ready/${id}`
    putData({ url: endpoint })
  }

  return (
    <div className="flex justify-center w-full p-1">
      <a className="flex flex-col items-center justify-between p-3 bg-white border border-gray-200 rounded-lg shadow md:flex-row w-2/3 hover:bg-gray-100 dark:border-gray-700 dark:bg-gray-800 dark:hover:bg-gray-700">
        <div className="flex flex-col items-start md:flex-row md:max-w-xl hover:bg-gray-100 dark:border-gray-700 dark:bg-gray-800 dark:hover:bg-gray-700">
          <img
            className="object-cover w-full rounded-t-lg h-96 md:h-auto md:w-48 md:rounded-none md:rounded-l-lg"
            src={img}
            alt="burger-img"
          />
          <div className="flex flex-col pl-3 justify-between leading-normal">
            <h5 className="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white">{product?.name}</h5>
            <p className="mb-3 font-normal text-gray-700 dark:text-gray-400">{product?.description}</p>
          </div>
        </div>
        <div className="flex h-full flex-col justify-between items-end">
          <div>
            <div className="flex gap-1 text-lg font-bold dark:text-white">
              <label>Quantity:</label>
              <p>{productQuantity}</p>
            </div>
            <div className="flex gap-1">
              <label>Created by:</label>
              <p>{createdBy}</p>
            </div>
            <div className="flex gap-1">
              <label>Created date:</label>
              <p>{new Date(createdDate).toLocaleTimeString()}</p>
            </div>
            {editedBy && (
              <div className="flex gap-1">
                <label>Edited by:</label>
                <p>{editedBy}</p>
              </div>
            )}
            {editedDate && (
              <div className="flex gap-1">
                <label>Edited date:</label>
                <p>{new Date(editedDate).toLocaleTimeString()}</p>
              </div>
            )}
          </div>
          <div className="flex justify-end w-full border-t pt-3">
            <Button color={'success'} size={'xs'} onClick={handleDoneClick}>
              <HiCheck />
              <p className="ml-1">Done</p>
            </Button>
          </div>
        </div>
      </a>
    </div>
  )
}
