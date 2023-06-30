import { useState } from 'react'
import { API_ENDPOINTS } from '../../common/api-endpoints'
import ProductCard from '../../components/product/product-card'
import { Product, Table } from '../models'
import { useGet } from '../../hooks/use-get'
import { TablesModal } from './tables-modal'
import { axios } from '../../main'

interface CreateOrderProps {
  productId: number
  productQuantity: number
}

export const Products = () => {
  const [isOpenTablesModal, setIsOpenTablesModal] = useState(false)
  const [createOrderData, setCreateOrderData] = useState<CreateOrderProps>()
  const { data: productsData } = useGet<Product[]>({ url: API_ENDPOINTS.PRODUCTS })
  // const { data, loading, error, postData } = usePost()
  const [loading, setLoading] = useState(false)

  const createOrder = async () => {
    const updatedData = { ...createOrderData, info: 'some info' }
    console.log('updated data', updatedData)

    try {
      const response = await axios.post(API_ENDPOINTS.ORDERS, updatedData)
      console.log(response.data)
      return response
    } catch (error) {
      console.error(error)
      throw error
    }
  }

  const onCofirm = async (table: Table) => {
    setLoading(true)
    try {
      const orderResponse = await createOrder()
      const endpoint = `/tables/${table.id}/orders/${orderResponse.data.id}`
      const assignTableResponse = await axios.post(endpoint)
      if (assignTableResponse.status === 200) {
        setLoading(false)
        closeTablesModal()
      }
      console.log('assignTableResponse', assignTableResponse)
    } catch (error) {
      console.error(error)
    }
  }

  const closeTablesModal = () => {
    setIsOpenTablesModal(false)
    setCreateOrderData(undefined)
  }
  const openTablesModal = () => {
    setIsOpenTablesModal(true)
  }

  const handleTableSelectClick = (product: Product, quantity: number) => {
    setCreateOrderData({ productId: product.categoryId, productQuantity: quantity })
    openTablesModal()
  }

  return (
    <div className="container mx-auto ">
      <div className="flex justify-center flex-wrap gap-4">
        {productsData.map((product) => (
          <ProductCard key={product.id} {...product} onTableSelectClick={handleTableSelectClick} />
        ))}
      </div>
      <TablesModal
        closeTablesModal={closeTablesModal}
        onCofirm={onCofirm}
        isOpen={isOpenTablesModal}
        loadingConfirm={loading}
      />
    </div>
  )
}
